using ImageMagick;
using System;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bildirim.Common.Helpers
{
    public class FileHelper
    {
        public static string RegExMethod(string img)
        {
            return Regex.Replace(img, @"^data:image\/[a-zA-Z]+;base64,", string.Empty);
        }

        public static string GetFileSize(long fileLength)
        {
            string[] sizes = { "B", "KB", "MB", "GB" };
            int order = 0;
            while (fileLength >= 1024 && order + 1 < sizes.Length)
            {
                order++;
                fileLength = fileLength / 1024;
            }
            string result = String.Format("{0:0.##} {1}", fileLength, sizes[order]);
            return result;
        }

        public static async Task OptimizeAndSaveAsNewImage(string _imagePath, string newImagePath, int width, int height)
        {
            if (File.Exists(newImagePath))
            {
                File.Delete(newImagePath);
            }

            using (var image = new MagickImage(_imagePath))
            {
                var templateRate = (double)width / height;

                var nowRate = (double)image.Width / image.Height;

                if (templateRate < nowRate)
                {
                    // Resize each image in the collection to a width of 200. When zero is specified for the height
                    // the height will be calculated with the aspect ratio.
                    image.Resize(0, height);
                    image.ChopHorizontal(width, image.Width - width);
                }
                else
                {
                    image.Resize(width, 0);
                    image.ChopVertical(height, image.Height - height);
                }

                image.Write(newImagePath);
            }

            using (var imageMagick = new MagickImage(newImagePath))
            {
                imageMagick.Transparent(MagickColor.FromRgb(0, 0, 0));
                imageMagick.FilterType = FilterType.Quadratic;
                imageMagick.Write(newImagePath);
            }

            FileInfo mainImage = new FileInfo(newImagePath);

            ImageOptimizer optimizer = new ImageOptimizer();
            optimizer.Compress(mainImage);
            mainImage.Refresh();
        }

        public static async Task OptimizeImage(string _imagePath, int width, int height)
        {
            using (var image = new MagickImage(_imagePath))
            {
                var templateRate = (double)width / height;

                var nowRate = (double)image.Width / image.Height;

                if (templateRate < nowRate)
                {
                    // Resize each image in the collection to a width of 200. When zero is specified for the height
                    // the height will be calculated with the aspect ratio.
                    image.Resize(0, height);
                    image.ChopHorizontal(width, image.Width - width);
                }
                else
                {
                    //以宽为准缩放
                    image.Resize(width, 0);
                    image.ChopVertical(height, image.Height - height);
                }

                image.Write(_imagePath);
            }

            using (var imageMagick = new MagickImage(_imagePath))
            {
                imageMagick.Transparent(MagickColor.FromRgb(0, 0, 0));
                imageMagick.FilterType = FilterType.Quadratic;
                imageMagick.Write(_imagePath);
            }

            FileInfo mainImage = new FileInfo(_imagePath);

            ImageOptimizer optimizer = new ImageOptimizer();
            optimizer.Compress(mainImage);
            mainImage.Refresh();
        }

        public static string ValidFileName(string name)
        {
            // first trim the raw string
            string safe = name.Trim();

            // replace spaces with hyphens
            safe = safe.Replace(" ", "-").ToLower();

            // replace any 'double spaces' with singles
            if (safe.IndexOf("--") > -1)
                while (safe.IndexOf("--") > -1)
                    safe = safe.Replace("--", "-");

            //Remove Turkish Chars
            safe = RemoveDiacritics(safe);

            // trim out illegal characters
            safe = Regex.Replace(safe, "[^a-z0-9\\-]", "");

            // trim the length
            if (safe.Length > 50)
                safe = safe.Substring(0, 49);
            // clean the beginning and end of the filename
            char[] replace = { '-', '.' };
            safe = safe.TrimStart(replace);
            safe = safe.TrimEnd(replace);
            return safe;
        }

        public static string RemoveIllegalFileNameChars(string input, string replacement = "")
        {
            var regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            var r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return r.Replace(input, replacement);
        }

        public static string RemoveDiacritics(string text)
        {
            Encoding srcEncoding = Encoding.UTF8;
            Encoding destEncoding = Encoding.GetEncoding(1252); // Latin alphabet

            text = destEncoding.GetString(Encoding.Convert(srcEncoding, destEncoding, srcEncoding.GetBytes(text)));

            string normalizedString = text.Normalize(NormalizationForm.FormD);
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < normalizedString.Length; i++)
            {
                if (!CharUnicodeInfo.GetUnicodeCategory(normalizedString[i]).Equals(UnicodeCategory.NonSpacingMark))
                {
                    result.Append(normalizedString[i]);
                }
            }

            return result.ToString();
        }

        public static string RemoveTurkishChars(string text)
        {
            string source = "ığüşöçĞÜŞİÖÇ";
            string destination = "igusocGUSIOC";

            for (int i = 0; i < source.Length - 1; i++)
            {
                text = text.Replace(source[i], destination[i]);
            }

            return text;
        }
    }
}
