using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class StudentView : UserControl
    {
        public Action edit = () => { };
        public Action delete = () => { };
        public Action check = () => { };
        public string code
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
        public string familyName
        {
            get
            {
                return label2.Text;
            }
            set
            {
                label2.Text = value;
            }
        }
        public string firstName
        {
            get
            {
                return label3.Text;
            }
            set
            {
                label3.Text = value;
            }
        }
        public string lastName
        {
            get
            {
                return label4.Text;
            }
            set
            {
                label4.Text = value;
            }
        }
        public Date birthDay
        {
            get
            {
                return Date.FromString(label5.Text);
            }
            set
            {
                label5.Text = value.SaveString();
            }
        }
        public string city
        {
            get
            {
                return label6.Text;
            }
            set
            {
                label6.Text = value;
            }
        }
        public string school
        {
            get
            {
                return label7.Text;
            }
            set
            {
                label7.Text = value;
            }
        }
        public int mathScore
        {
            get
            {
                return int.Parse(label8.Text);
            }
            set
            {
                label8.Text = value.ToString();
            }
        }
        public int physicsScore
        {
            get
            {
                return int.Parse(label9.Text);
            }
            set
            {
                label9.Text = value.ToString();
            }
        }
        public int eyeshOn
        {
            get
            {
                return int.Parse(label10.Text);
            }
            set { label10.Text = value.ToString(); }
        }


        public StudentView()
        {
            InitializeComponent();
            button1.Click += (object sender, EventArgs e) =>
            {
                edit();
            };
            button2.Click += (object sender, EventArgs e) =>
            {
                delete();
            };
            button3.Click += (object sender, EventArgs e) =>
            {
                check();
            };
        }
    }
}
