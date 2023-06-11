using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace server.Models
{
    public class Message
    {
        public int MessageId { get; set; }

        public string MessageText { get; set; }

        public int? MessageUserId { get; set; }

        public virtual User MessageUser { get; set; }
    }
}
