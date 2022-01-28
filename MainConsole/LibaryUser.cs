using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole
{
    class LibaryUser:Human
    {
        
        public int NumberTicket { get; set;}
        public DateTime DateOfIssue { get; set; }
        public double SizeDeposit { get; set; }
        public LibaryUser(string firstname, string lastname, DateTime dateOfBirthd,
            int numberticket, DateTime dateIssue, double sizeDeposit) : base(firstname,
                lastname, dateOfBirthd)
        {
            NumberTicket = numberticket;
            DateOfIssue = dateIssue;
            SizeDeposit = sizeDeposit;
        }
        public string GetNumbAndDepos()
        {
            string number = $"Номер білету:{NumberTicket.ToString()}" +
                $"(pозмір Депозиту:{SizeDeposit.ToString()})";
            
            return number;
        }

    }
}
