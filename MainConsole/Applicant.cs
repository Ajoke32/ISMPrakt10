using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole
{
    class Applicant:Human
    {
        public ZNOpoint Balls {get;set;}
        public int EducationDocument { get; set;}
        public string NameInstitution { get; set; }
        public Applicant(string firstname,string lastname,DateTime dateOfBirthd,
            ZNOpoint balls, int educationDoc, string nameInstitution)
            :base(firstname,lastname,dateOfBirthd)
        {
            Balls = balls;
            EducationDocument = educationDoc;
            NameInstitution = nameInstitution;
        }
    }
}
