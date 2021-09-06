using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class ClassRoom
    {

        public string ClassName { get; set; }

        public List<Student> ClassList { get; set; }

        public DateTime SemesterStart { get; set; }


        public void BirthdayPerSeason()
        {
            var winterList = ClassList.Where(s => s.Season(s.BirthMonth) == "Winter");
            var summerList = ClassList.Where(s => s.Season(s.BirthMonth) == "Summer");
            var springList = ClassList.Where(s => s.Season(s.BirthMonth) == "Spring");
            var autumnList = ClassList.Where(s => s.Season(s.BirthMonth) == "autumn");

            Console.WriteLine($"\nTotal Amount of Bdays per season");
            Console.WriteLine($"{summerList.Count()} in Summer.\n");
            Console.WriteLine($"{winterList.Count()} in Winter.\n");
            Console.WriteLine($"{springList.Count()} in Spring.\n");
            Console.WriteLine($"{autumnList.Count()} in Autumn.\n");
        }

    }
}
