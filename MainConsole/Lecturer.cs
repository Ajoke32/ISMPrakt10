using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole
{
    class Lecturer:Human
    {
       
        public string Position { get; set; }
        public string Department { get; set; }
        public string NameUniversuty { get; set; }
        public Lecturer(string firstname, string lastname, DateTime dateofBirthd,
            string position, string department, string university) :
            base(firstname, lastname, dateofBirthd)
        {
            Position = position;
            Department = department;
            NameUniversuty = university;
        }
        public string GetPosAndDep()
        {
            string positions =$"Position:{Position}(Department:{Department})";

            return positions;

        }
    }
}
