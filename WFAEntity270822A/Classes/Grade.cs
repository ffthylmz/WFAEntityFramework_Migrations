using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAEntity270822A.Classes
{
    public class Grade
    {
        public int ID { get; set; }
        public int Value { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
