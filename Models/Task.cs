using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace server.Models
{
    public class Task
    {
        public int TaskId { get; set; }

        public string TaskText { get; set; }

        public int? TaskTheoryId { get; set; }

        public int TaskTeacherId { get; set; }

        public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();

        public virtual Teacher TaskTeacher { get; set; }

        public virtual Theory TaskTheory { get; set; }
    }
}
