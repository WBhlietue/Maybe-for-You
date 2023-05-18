using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;

namespace lab7
{
    public partial class Form2 : Form
    {
        int num = 0;
        Student student;
        bool edit = false;
        public Form2()
        {
            InitializeComponent();
            textBox5.Text = "0";
        }
        public Form2(Student s)
        {
            InitializeComponent();
            edit= true;
            student = s;
            textBox1.Text = s.code;
            textBox2.Text = s.name;
            textBox3.Text = s.hicheelCode;
            textBox4.Text = s.hicheelName;
            comboBox1.Text = s.uliral;
            textBox5.Text = s.score + "";
            button1.Text = "Өөрчлөх";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Код хоосон байна.");
            }
            else if(textBox1.Text.Length != 10)
            {
                MessageBox.Show("Кодын урт 10 байх ёстой.");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Нэр хоосон байна.");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Хичээлийн код хоосон байна.");
            }
            else if (textBox3.Text.Length != 7)
            {
                MessageBox.Show("Хичээлийн кодын урт 7 байх ёстой.");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Хичээлийн нэр хоосон байна.");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("Оноо хоосон байна.");
            }
            else
            {
                if (edit)
                {
                    student.Delete();
                }
                Student st = new Student(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, comboBox1.Text, int.Parse(textBox5.Text));
                st.Save();
                Form1.instance.Set();
                this.Close();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                num = int.Parse(textBox5.Text);
                num = Math.Min(Math.Max(num, 0), 100);
                textBox5.Text = num + "";
            }
            catch
            {
                if (textBox5.Text.Length == 0)
                {
                    textBox5.Text = "0";
                }
                else
                {
                    textBox5.Text = num + "";
                }
            }
            textBox5.SelectionStart = textBox5.Text.Length;
        }
    }
}
