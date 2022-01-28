using System;


namespace MainConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Anton", "Golovatyk", new DateTime(2003, 9, 14));
            int age = human.GetAge();
            Applicant applicant = new Applicant("Anton", "Golovatyk",
                new DateTime(2003, 9, 14), new ZNOpoint(100, 114, 151), 9,
                "Zhytomyr gymnasium №5");
            int sumballs = applicant.GetSumBalls();
            Student student = new Student("Anton", "Golovatyk", new DateTime(2003, 9, 14),
                "2","IPZ-21-1","Software Engineering","Zhytomyr polytechnic");
            string studentinfo = student.GetGroupAndCourse();
            Lecturer lecturer = new Lecturer("Denis", "Logvinov", new DateTime(1997, 10, 9),
                "Teacher", "Software Engineering", "Zhytomyr polytechnic");
            string lectirerinfo = lecturer.GetPosAndDep();
            LibaryUser libaryUser = new LibaryUser("Anton", "Golovatyk", new DateTime(2003, 9, 14),
                45,new DateTime(2012,4,23),455.40);
            string userinfo = libaryUser.GetNumbAndDepos();
            Console.WriteLine($"Object Human\nAge:{age}\n\nObject Applicant\nSum balls:{sumballs}\n\n" +
                $"Object Student\nGroup:{studentinfo}\n\n" +
                $"Object Lecturer\n{lectirerinfo}\n\nObject Libary User\n{userinfo}");
        }
    }
}
