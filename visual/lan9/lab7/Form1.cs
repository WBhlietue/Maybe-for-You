using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        List<Student> selected = new List<Student>();
        public static Form1 instance;
        public Form1()
        {
            instance = this;
            InitializeComponent();
            Set();
        }

        public void Set()
        {
            flowLayoutPanel1.Controls.Clear();
            StudentView v = new StudentView();
            v.button2.Hide();
            v.button1.Hide();
            v.checkBox1.Hide();
            flowLayoutPanel1.Controls.Add(v);
            List<Student> std = Student.GetStudent();
            foreach(var item in std)
            {
                SetStudent(item);
            }
        }

        void SetStudent(Student student)
        {
            StudentView top = new StudentView();
            top.name = student.name;
            top.code = student.code;
            top.hicheelCode= student.hicheelCode;
            top.hicheelName = student.hicheelName;
            top.uliral = student.uliral;
            top.score = student.score.ToString();
            top.delete = () =>
            {
                student.Delete();
                Set();
            };
            top.check = (b) => {
                if (b)
                {
                    selected.Add(student);
                }
                else
                {
                    selected.Remove(student);
                }
            };
            top.edit = () =>
            {
                new Form2(student).Show();
            };
            flowLayoutPanel1.Controls.Add(top);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(var item in selected)
            {
                item.Delete();
            }
                Set();
        }
    }
}
