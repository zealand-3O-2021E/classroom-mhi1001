using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Student
    {
        private string _name;
        private int _birthMonth;
        private int _birthDay;


        public Student(string name, int birthmonth, int birthday  )
        {
            _name = name;
            _birthMonth = birthmonth;
            _birthDay = birthday;
        }


        public string Name
        {
            get { return _name; }
        }

        public int BirthMonth
        {
            get { return _birthMonth; }
        }

        public int BirthDay
        {
            get { return _birthDay; }
        }

        public string Season(int birthmonth)
        {

            switch (birthmonth)
            {
                case int n when (n >= 1 && n <= 2 || n == 12):
                    return "Winter";

                case int n when (n >= 3 && n <= 5):
                    return "Spring";
                case int n when (n >= 6 && n <= 8):
                    return "Summer";
                case int n when (n >= 9 && n <= 11):
                    return "Autumn";
                default:
                    return "Invalid";

            }
            
        }
    }
}
