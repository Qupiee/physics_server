using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace server.Models
{
    public class Group
    {
        public int GroupId { get; set; }

        public int GroupLabel { get; set; }

        public int GroupStudentId { get; set; }

        public virtual Student GroupStudent { get; set; }
    }
}
