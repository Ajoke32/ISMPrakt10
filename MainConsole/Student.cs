using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MainConsole
{
    class Student:Human
    {
      
        public string Course { get; set; }
         public string Group { get; set; }
        public string Faculty { get; set; }
        public string University { get; set; }
        public Student(string firstname, string lastname, DateTime dateofbirthd,
            string course, string group, string faculty, string university)
            :base(firstname,lastname,dateofbirthd)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            University = university;
        }

        public string GetGroupAndCourse()
        {
            
            string a = $"{Group}(курс {Course})";
            return a;
        }
    }
}
