using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAEntity270822A.Classes
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }

        //Navigation Property

        public Instructor Instructor { get; set; }
        public int InstructorID { get; set; }
    }
}
