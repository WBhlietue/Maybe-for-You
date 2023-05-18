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
    public partial class StudentView : UserControl
    {
        public Action delete = () => { };
        public Action edit = () => { };
        public Action<bool> check = (f) => { };
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
        public string name
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
        public string hicheelCode
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
        public string hicheelName
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
        public string uliral
        {
            get
            {
                return label5.Text;
            }
            set
            {
                label5.Text = value;
            }
        }
        public string score
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


        public StudentView()
        {
            InitializeComponent();
            button2.Click += (object sender, EventArgs e) =>
            {
                delete();
            };
            button1.Click += (object sender, EventArgs e) =>
            {
                edit();
            };
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            check(checkBox1.Checked);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
