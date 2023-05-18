using System;
using System.Management;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace lab7
{
    public static class Program
    {

        public static MySqlConnection con = new MySqlConnection("");

        [STAThread]
        static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Student
    {
        public string code;
        public string name;
        public string hicheelCode;
        public string hicheelName;
        public string uliral;
        public int score;
        public Student(string code, string name, string hicheelCode, string hicheelName, string uliral, int score)
        {
            this.code = code;
            this.name = name;
            this.hicheelCode = hicheelCode;
            this.hicheelName = hicheelName;
            this.uliral = uliral;
            this.score = score;
        }

        public void Save()
        {
            try
            {
                MySqlConnection con = Program.con;
                con.Open();
                MySqlDataReader rd = new MySqlCommand("select count(*) from Student where sCode='" + code + "' and hCode='" 
                                    + hicheelCode + "' and jil='" + uliral + "'", con).ExecuteReader();
                rd.Read();
                int num = rd.GetInt32(0);
                rd.Close();

                if (num == 0)
                {
                    new MySqlCommand("insert into Student values('" + code + "','" + name + "','" + hicheelCode + "','" 
                                    + hicheelName + "','" + uliral + "'," + score + ")", con).ExecuteNonQuery();
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("save error");
            }
        }
        public void Delete()
        {
            try
            {
                MySqlConnection con = Program.con;
                con.Open();
                MySqlDataReader rd = new MySqlCommand("select count(*) from Student where sCode='" + code + "' and hCode='" + hicheelCode + "' and jil='" + uliral + "'", con).ExecuteReader();
                rd.Read();
                int num = rd.GetInt32(0);
                rd.Close();

                if (num == 1)
                {
                    new MySqlCommand("delete from Student where sCode='" + code + "' and hCode='" + hicheelCode + "' and jil='" + uliral + "'", con).ExecuteNonQuery();
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("delete error");
            }
        }
        public  static List<Student> GetStudent()
        {
            try
            {
                MySqlConnection con = Program.con;
                List<Student> student = new List<Student>();
                con.Open();
                MySqlDataReader rd = new MySqlCommand("select * from Student order by sCode", con).ExecuteReader();
                while (rd.Read())
                {
                    student.Add(new Student(rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetInt32(5)));
                }
                rd.Close();
                con.Close();

                return student;
            }
            catch
            {
                MessageBox.Show("get error");
                return new List<Student>();
            }
        }
    }


}
