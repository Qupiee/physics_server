using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace server.Models
{
    public class Admin
    {
        public int AdminId { get; set; }

        public string AdminFullName { get; set; }

        public virtual User AdminNavigation { get; set; }
    }
}
