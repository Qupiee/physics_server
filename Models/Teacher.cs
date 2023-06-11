using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace server.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        public string TeacherFullName { get; set; }

        public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();

        public virtual User TeacherNavigation { get; set; }
    }
}
