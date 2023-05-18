using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab6
{
    public partial class NewStudent : Form
    {
        int m = 0, p = 0, ey = 0;

        public NewStudent()
        {
            InitializeComponent();
        }
        public NewStudent(Student st)
        {
            InitializeComponent();
            button2.Text = "Өөрчлөх";
            code.Text = st.code;
            famName.Text = st.familyName;
            firstName.Text= st.firstName;
            lastName.Text= st.lastName;
            birthDay.Text = st.birthday.SaveString();
            city.Text = st.city;
            school.Text = st.school;
            math.Text = st.mathScore + "";
            phycis.Text = st.physicsScore + "";
            eyesh.Text = st.eyeshYear + "";
            code.Enabled = false;

        }



        private void math_TextChanged(object sender, EventArgs e)
        {
            try
            {
                m = int.Parse(math.Text);
                math.Text = m + "";
            }
            catch
            {
                if (math.Text.Length == 0)
                {
                    math.Text = "0";
                }
                else
                {
                    math.Text = m + "";
                }
            }
            math.SelectionStart = math.Text.Length;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String sCode = code.Text;
            String sFamNamae = famName.Text;
            String sLastName = lastName.Text;
            String sFirstName = firstName.Text;
            String sBirth = birthDay.Text;
            String sCity = city.Text;
            String sSchool = school.Text;
            int sMath = m;
            int sPhysic = p;
            int sEyesh = ey;
            try
            {
                Date bir = Date.FromString(sBirth);
                if (sCode == "" || sFamNamae == "" || sLastName == "" || sFirstName == "" || sCity == "" || sSchool == "")
                {
                    MessageBox.Show("Хоосон байж болохгүй");
                }
                else
                {
                    if (Form1.instance.CanUseCode(sCode) || !code.Enabled)
                    {
                        Student std = new Student(sCode, sFamNamae, sFirstName, sLastName, bir, sCity, sSchool, sEyesh, sMath, sPhysic);
                        Form1.instance.AddStudent(std);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Код давхцаж байна");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Date format invalid");
            }
            
        }

        private void phycis_TextChanged(object sender, EventArgs e)
        {
            try
            {
                p = int.Parse(phycis.Text);
                phycis.Text = p + "";
            }
            catch
            {
                if (phycis.Text.Length == 0)
                {
                    phycis.Text = "0";
                }
                else
                {
                    phycis.Text = p + "";
                }
            }
            phycis.SelectionStart = phycis.Text.Length;
        }

        private void eyesh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ey = int.Parse(eyesh.Text);
                eyesh.Text = ey + "";
            }
            catch
            {
                if (eyesh.Text.Length == 0)
                {
                    eyesh.Text = "0";
                }
                else
                {
                    eyesh.Text =ey + "";
                }
            }
            eyesh.SelectionStart = eyesh.Text.Length;
        }
    }
}
