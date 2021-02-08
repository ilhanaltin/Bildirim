using System;
using System.Collections.Generic;
using System.Text;

namespace Bildirim.Domain.Model
{
    public class BaseVM
    {
        public long Id { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime? UpdatedDateTime { get; set; }

        public long CreatedUserId { get; set; }

        public long? UpdatedUserId { get; set; }
    }
}
