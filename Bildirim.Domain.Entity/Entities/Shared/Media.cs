using Bildirim.Domain.Entities.Entity;
using Bildirim.Domain.Entity.Entities.Types;

namespace Bildirim.Domain.Entity.Entities.Shared
{
    public class Media : BaseEntity
    {
        public string FilePath { get; set; }

        public string FileName { get; set; }

        public long Size { get; set; }

        public long FileTypeId { get; set; }

        public virtual FileType FileType { get; set; }
    }
}
