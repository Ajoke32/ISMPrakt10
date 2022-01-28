using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MainConsole
{
     public class Student:Human
    {
      
        public int Course { get; set; }
         public string Group { get; set; }
        public string Faculty { get; set; }
        public string University { get; set; }
        public Student(string firstname, string lastname, DateTime dateofbirthd,
            int course, string group, string faculty, string university)
            :base(firstname,lastname,dateofbirthd)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            University = university;
        }

        public string GetGroupAndCourse()
        {
            
            string a = $"{Group}(course {Course})";
            return a;
        }
    }
}
