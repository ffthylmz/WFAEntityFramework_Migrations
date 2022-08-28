using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAEntity270822A.Classes
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string RegistrationNumber { get; set; }
        public ICollection<StudentCourse> StudentCourse { get; set; }   //birden fazla değer içerdiği için kolleksiyon yaptık.

    }
}
