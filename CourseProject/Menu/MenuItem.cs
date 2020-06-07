using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Menu
{
    public class MenuItem
    {
        public string ItemText { get; set; }

        public List<MenuItem> SubItems { get; set; } = new List<MenuItem>();
    }
}
