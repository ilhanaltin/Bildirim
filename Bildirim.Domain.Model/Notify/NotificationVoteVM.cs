using System;
using System.Collections.Generic;
using System.Text;

namespace Bildirim.Domain.Model.Notify
{
    public class NotificationVoteVM : BaseVM
    {
        public long UserId { get; set; }

        public string UserName { get; set; }

        public string UserNickName { get; set; }
    }
}
