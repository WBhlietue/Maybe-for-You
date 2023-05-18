using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        List<Student> students = new List<Student>();
        public Form1()
        {
            instance = this;
            InitializeComponent();
            view1.button1.Hide();
            view1.button2.Hide();
            view1.button3.Hide();
            Load();
            RefreshView();
        }

        public void Load()
        {
            try
            {
                StreamReader reader = new StreamReader("../../data.txt");
                string line = reader.ReadLine();
                while (line != null)
                {
                    try
                    {
                        students.Add(Student.FromString(line));
                    }
                    catch { }
                    line = reader.ReadLine();
                }
                reader.Close();
            }
            catch { }
        }
        public void Save()
        {
            try
            {
                StreamWriter write = new StreamWriter("../../data.txt");
                foreach (var item in students)
                {
                    try
                    {
                        write.WriteLine(item.SaveString());
                    }
                    catch { }
                }
                write.Close();
            }
            catch { }
        }

        public void AddStudent(Student st)
        {
            for(int i = 0; i < students.Count; i++)
            {
                if (students[i].code == st.code)
                {
                    students[i] = st;
                    Save();
                    RefreshView();
                    return;
                }
            }
            students.Add(st);
            Save();
            RefreshView();
        }

        public void Edit(Student st)
        {
            new NewStudent(st).Show();
        }
        public void Delete(Student st)
        {
            students.Remove(st);
            Save(); 
            RefreshView();
        }
        public void Check(Student st)
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int age = year - st.birthday.year;
            if (month < st.birthday.month)
            {
                age--;
            }
            else if (month == st.birthday.month)
            {
                if (day < st.birthday.day)
                {
                    age--;
                }
            }
            int eye = year - st.eyeshYear;
            int score = (st.mathScore * 7 + st.physicsScore * 3) / 10;
            if (age >= 16 && age <= 20 && eye <= 2 && score >= 550)
            {
                MessageBox.Show("Суралцах эрх олгож болно");
            }
            else
            {
                MessageBox.Show("Суралцах эрх олгохгүй");
            }
        }

        void RefreshView()
        {

            flowLayoutPanel1.Controls.Clear();
            foreach (var item in students)
            {
                GetView(item);
            }
        }

        private void view1_Load(object sender, EventArgs e)
        {

        }
        StudentView GetView(Student st)
        {
            StudentView studentView1 = new StudentView();
            studentView1.Location = new System.Drawing.Point(3, 3);
            studentView1.Name = "studentView1";
            studentView1.school = "label7";
            studentView1.Size = new System.Drawing.Size(1220, 75);
            studentView1.TabIndex = 0;
            studentView1.code = st.code;
            studentView1.familyName = st.familyName;
            studentView1.firstName = st.firstName;
            studentView1.lastName = st.lastName;
            studentView1.birthDay = st.birthday;
            studentView1.city = st.city;
            studentView1.school = st.school;
            studentView1.mathScore = st.mathScore;
            studentView1.physicsScore = st.physicsScore;
            studentView1.eyeshOn = st.eyeshYear;
            studentView1.check = () => { Check(st); };
            studentView1.delete = () => { Delete(st); };
            studentView1.edit = () => { Edit(st); };
            flowLayoutPanel1.Controls.Add(studentView1);
            return studentView1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new NewStudent().Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public bool CanUseCode(String code)
        {
            foreach (var item in students)
            {
                if (item.code == code)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
