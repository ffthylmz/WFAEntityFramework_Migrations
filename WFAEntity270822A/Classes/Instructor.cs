using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAEntity270822A.Classes
{
    public class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string RegistrationNumber { get; set; }

        public Department Department { get; set; }  //Department tablosuyla ilişkisini kurduk.
    }
}
