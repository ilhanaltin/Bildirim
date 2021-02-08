using System;
using System.Collections.Generic;
using System.Text;

namespace Bildirim.Domain.Model.ReqRes
{
    public class DeleteRequest
    {
        public int Id { get; set; }
    }

    public class DeleteMultipleRequest
    {
        public List<int> Ids { get; set; }
    }
}
