using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Main
    {

    }
    //Код, Ургийн овог, Овог, Нэр, Төрсөн огноо, Төрсөн газар, Төгссөн сургууль, ЭЕШ өгсөн он, ЭЕШ-ийн оноо Мат/Физик;
    public class Student
    {
        public string code;
        public string familyName;
        public string firstName;
        public string lastName;
        public Date birthday;
        public string city;
        public string school;
        public int eyeshYear;
        public int mathScore;
        public int physicsScore;

        public Student (string code, string familyName, string firstName, string lastName, Date birthday, string city, string school, int eyeshYear, int mathScore, int physicsScore)
        {
            this.code = code;
            this.familyName = familyName;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
            this.city = city;
            this.school = school;
            this.eyeshYear = eyeshYear;
            this.mathScore = mathScore;
            this.physicsScore = physicsScore;
        }
        public bool CheckCanSduty()
        {
            int year = DateTime.Now.Year;
            if(year - birthday.year >= 16 && year - birthday.year <= 20 && year - eyeshYear <= 2 && (mathScore * 7 + physicsScore * 3) >= 5500){
                return true;
            }
            return false;
        }
        public string SaveString()
        {
            return code + "`" + familyName + "`" + firstName + "`" + lastName + "`" + birthday.SaveString() + "`" + city + "`" + school + "`" + eyeshYear + "`" + mathScore + "`" + physicsScore; 
        }
        public static Student FromString(string s)
        {
            string[] str = s.Split('`');
            return new Student(str[0], str[1], str[2], str[3], Date.FromString(str[4]), str[5], str[6], int.Parse(str[7]), int.Parse(str[8]), int.Parse(str[9]));
        }
    }
    public class Date
    {
        public int year;
        public int month;
        public int day;
        public Date (int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public string SaveString()
        {
            return year + "-" + month + "-" + day;
        }
        public static Date FromString(string str)
        {
            string[] strs = str.Split('-');
            return new Date(int.Parse( strs[0]), int.Parse(strs[1]), int.Parse(strs[2]));
        }
    }
}
