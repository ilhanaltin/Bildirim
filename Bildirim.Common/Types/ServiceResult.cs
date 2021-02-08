using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Bildirim.Common.Types
{
    public class ServiceResult<T> where T : new()
    {
        public List<string> Messages { get; set; }
        public T Result { get; set; }
        public HttpStatusCode Status { get; set; }

        public ServiceResult()
        {
            Result = new T();
            Status = HttpStatusCode.OK;
            Messages = new List<string>();
        }

        public void AddMessage(string message)
        {
            if (!string.IsNullOrEmpty(message))
                Messages.Add(message);
        }

        public void AddMessage(List<string> messages)
        {
            if (messages == null || messages.Count == 0)
                return;

            Messages.AddRange(messages.Where(p => !string.IsNullOrEmpty(p)));
        }

        public string GetFormattedMessages()
        {
            if (Messages == null || Messages.Count == 0)
                return string.Empty;
            StringBuilder builder = new StringBuilder();
            Messages.ForEach(p =>
            {
                builder.AppendLine(p);
            });
            return builder.ToString();
        }
    }
}
