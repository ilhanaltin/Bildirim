using System;

namespace Bildirim.Domain.Model.Shared
{
    public class MediaVM
    {
        public long Id { get; set; }
        public string FilePath { get; set; }

        public string FileName { get; set; }

        public string Size { get; set; }

        public long FileTypeId { get; set; }

        public string FileTypeName { get; set; }

        public DateTime Date { get; set; }
    }
}
