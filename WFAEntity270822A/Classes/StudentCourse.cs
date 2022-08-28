using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAEntity270822A.Classes
{
    public class StudentCourse
    {
        public int ID { get; set; }

        public Student Student { get; set; }
        public int StudentID { get; set; }

        public Course Course { get; set; }
        public int CourseID { get; set; }

        public Grade Grade { get; set; }
        public int GradeID { get; set; }


    }
}
