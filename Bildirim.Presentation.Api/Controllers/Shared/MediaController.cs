using AutoMapper;
using Bildirim.Common;
using Bildirim.Common.Helpers;
using Bildirim.Common.Types;
using Bildirim.Domain.Entity.Entities.Shared;
using Bildirim.Domain.Model.ReqRes;
using Bildirim.Domain.Model.Shared;
using Bildirim.Infrastructure.Main.UnitOfWork;
using EasyCaching.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;

namespace Bildirim.Presentation.Api.Controllers.Shared
{
    [ApiController]
    [Route("api/[controller]")]
    public class MediaController : BaseController
    {
        private readonly IEasyCachingProviderFactory _factory;

        public MediaController(IUnitOfWork unitOfWork, IMapper mapper, IEasyCachingProviderFactory factory)
            : base(unitOfWork, mapper)
        {
            this._factory = factory;
        }

        [HttpGet]
        public ServiceResult<MediaListResponseDetails> Get([FromQuery] MediaListRequest request)
        {
            var mediasQuery = _unitOfWork.MediaRepository.GetAll();

            if (request.Month.HasValue && request.Year.HasValue)
            {
                mediasQuery = mediasQuery.Where(t => t.CreatedDateTime.Year == request.Year && t.CreatedDateTime.Month == request.Month);
            }

            //for manuel paging process
            var paging = new PagingVM();
            paging.TotalCount = mediasQuery.Count();
            paging.TotalPage = Math.Ceiling(((decimal)paging.TotalCount / request.ItemCount));
            paging.CurrentPage = request.PageId;
            paging.PageItemCount = request.ItemCount;

            var medias = mediasQuery.OrderByDescending(o => o.Id).Skip((request.PageId) * request.ItemCount)
                .Include(x => x.FileType)
                .Take(request.ItemCount).ToList();

            var postsVM = _mapper.Map<List<Media>, List<MediaVM>>(medias);

            var response = new ServiceResult<MediaListResponseDetails>();

            response.Status = HttpStatusCode.OK;
            response.Result.MediaList = postsVM;
            response.Result.PagingVM = paging;

            return response;
        }

        [HttpPost]
        public ServiceResult<StandartResponseDetails> Post([FromBody] MediaRequest request)
        {
            var response = new ServiceResult<StandartResponseDetails>();

            var filePath = string.Empty;

            if (request.File.Length <= 0)
            {
                response.Status = HttpStatusCode.InternalServerError;
                return response;
            }

            string file = Path.GetFileNameWithoutExtension(request.FileName);

            request.FileName = request.FileName.Replace(file, FileHelper.ValidFileName(file));

            var media = new Media();
            media.FileName = request.FileName;
            media.CreatedUserId = request.UserId;

            #region Save File To Disk

            string directory = "Images";

            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            directory = string.Format("Images/Media/{0}", year);

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            directory = string.Format("Images/Media/{0}/{1}", year, month);

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            byte[] bytes = Convert.FromBase64String(FileHelper.RegExMethod(request.File));
            media.Size = bytes.Length;

            using (Image image = Image.FromStream(new MemoryStream(bytes)))
            {
                if (ImageFormat.Jpeg.Equals(image.RawFormat))
                {
                    filePath = Path.Combine(directory, request.FileName);

                    if (System.IO.File.Exists(filePath))
                    {
                        System.IO.File.Delete(filePath);
                    }

                    media.FileTypeId = Constants.FILE_TYPE_IMAGE;
                    image.Save(filePath, ImageFormat.Jpeg);
                }
                else if (ImageFormat.Png.Equals(image.RawFormat))
                {
                    filePath = Path.Combine(directory, request.FileName);

                    if (System.IO.File.Exists(filePath))
                    {
                        System.IO.File.Delete(filePath);
                    }

                    media.FileTypeId = Constants.FILE_TYPE_IMAGE;

                    image.Save(filePath, ImageFormat.Png);
                }
            }

            filePath = filePath.Replace("\\", "/");

            file = Path.GetFileNameWithoutExtension(request.FileName);

            string newImagePath = filePath.Replace(file, string.Format("{0}_{1}_{2}", file, 120, 80));

            FileHelper.OptimizeAndSaveAsNewImage(filePath, newImagePath, 120, 80);
            FileHelper.OptimizeImage(filePath, 730, 490);

            media.FilePath = filePath;

            #endregion

            if (request.Id > 0)
            {
                _unitOfWork.MediaRepository.Update(media);
            }
            else
            {
                _unitOfWork.MediaRepository.Add(media);
            }

            response.Status = HttpStatusCode.OK;

            return response;
        }

        [HttpPost("DeleteMedia")]
        public ServiceResult<StandartResponseDetails> DeleteMedia([FromBody] DeleteRequest request)
        {
            var response = new ServiceResult<StandartResponseDetails>();

            var media = _unitOfWork.MediaRepository.Get(t => t.Id == request.Id);

            if (media == null)
            {
                response.Status = HttpStatusCode.NotFound;
                return response;
            }

            _unitOfWork.MediaRepository.Remove(media);

            if (System.IO.File.Exists(media.FilePath))
            {
                System.IO.File.Delete(media.FilePath);
            }

            string file = Path.GetFileNameWithoutExtension(media.FilePath);
            string newImagePath = media.FilePath.Replace(file, string.Format("{0}_{1}_{2}", file, 120, 80));

            if (System.IO.File.Exists(newImagePath))
            {
                System.IO.File.Delete(newImagePath);
            }

            response.Status = HttpStatusCode.OK;

            return response;
        }
    }
}