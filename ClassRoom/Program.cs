using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom cs201 = new ClassRoom();
            cs201.ClassName = "3Q";
            cs201.SemesterStart = new DateTime(2019,08,26);
            cs201.ClassList = new List<Student>();

            Student s1 = new Student("Pedro", 12, 7);
            Student s2 = new Student("Alex", 6, 7);
            Student s3 = new Student("Radu", 01, 7);
            Student s4 = new Student("Kristaps", 02, 7);

            cs201.ClassList.Add(s1);
            cs201.ClassList.Add(s2);
            cs201.ClassList.Add(s3);
            cs201.ClassList.Add(s4);

            
            Console.WriteLine($"ClassName: {cs201.ClassName}");
            Console.WriteLine($"Semester Start {cs201.SemesterStart.ToShortDateString()}");
            Console.WriteLine($"\nHas the following students:");
            foreach (Student student in cs201.ClassList)
            {
                Console.WriteLine($"\nName: {student.Name}, Birthday: {student.BirthDay}, BirthMonth: {student.BirthMonth}");
            }

            Console.WriteLine($"\n{s1.Name} - {s1.Season(s1.BirthMonth)}");
            Console.WriteLine($"\n{s2.Name} - {s2.Season(s2.BirthMonth)}");
            Console.WriteLine($"\n{s3.Name} - {s3.Season(s3.BirthMonth)}");
            Console.WriteLine($"\n{s4.Name} - {s4.Season(s4.BirthMonth)}");


            cs201.BirthdayPerSeason();

            Student s5 = new Student("Error", 12, 30);
            s5.BirthMonth = 30;

            Console.ReadLine();
        }
    }
}
