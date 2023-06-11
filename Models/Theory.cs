using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace server.Models
{
    public class Theory
    {
        public int TheoryId { get; set; }

        public string TheoryTheme { get; set; }

        public string TheorySection { get; set; }

        public string TheoryText { get; set; }

        public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
    }
}
