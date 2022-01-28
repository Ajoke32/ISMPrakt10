using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole
{
   public class LibaryUser:Human
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
            string number = $"Ticket number:{NumberTicket.ToString()}" +
                $"(Size Deposit:{SizeDeposit.ToString()})";
            
            return number;
        }

    }
}
