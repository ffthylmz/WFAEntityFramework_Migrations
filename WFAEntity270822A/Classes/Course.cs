using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAEntity270822A.Classes
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Credit { get; set; }
        public ICollection<StudentCourse> StudentCourse { get; set; }
    }
}
