﻿using Bildirim.Infrastructure.Main.Repositories.Interfaces.Authorization;
using Bildirim.Infrastructure.Main.Repositories.Interfaces.Notify;
using Bildirim.Infrastructure.Main.Repositories.Interfaces.Shared;
using Bildirim.Infrastructure.Main.Repositories.Interfaces.Types;
using System;

namespace Bildirim.Infrastructure.Main.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        #region Authorization

        IUserRepository UserRepository { get; }
        IUserRoleRepository UserRoleRepository { get; }
        IUserVerificationRepository UserVerificationRepository { get; }
        ILoginRepository LoginRepository { get; }
        ITokenRepository TokenRepository { get; }

        #endregion

        #region Notify

        INotificationRepository NotificationRepository { get; }
        INotificationVoteRepository NotificationVoteRepository { get; }

        #endregion

        #region Campaign

        ICampaignRepository CampaignRepository { get; }
        IUserFavoriteCategoriesRepository UserFavoriteCategoriesRepository { get; }

        #endregion

        #region Shared

        ISectorRepository SectorRepository { get; }
        ICityRepository CityRepository { get; }
        ICountyRepository CountyRepository { get; }
        IBrandRepository BrandRepository { get; }

        IMediaRepository MediaRepository { get; }

        #endregion

        #region Types

        IRoleTypeRepository RoleTypeRepository { get; }
        IUserStatusTypeRepository UserStatusTypeRepository { get; }
        INotificationTypeRepository NotificationTypeRepository { get; }

        #endregion

        void Commit();

        /// <summary>
        /// Return the database reference for this UOW
        /// </summary>
        //DbContext Db { get; }

        /// <summary>
        /// Starts a transaction on this unit of work
        /// </summary>
        void StartTransaction();
    }
}
