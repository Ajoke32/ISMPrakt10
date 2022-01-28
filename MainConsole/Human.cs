using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole
{
    public class Human
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirthd { get; set; }

        public Human(string firstName, string lastName,DateTime dateOfBirthd)
        {
            FirstName = firstName;
            Lastname = Lastname;
            DateOfBirthd = dateOfBirthd;
        }
        public int GetAge()
        {
            TimeSpan age = DateTime.Now - DateOfBirthd;
            return age.Days / 365;
        }
    }
}
