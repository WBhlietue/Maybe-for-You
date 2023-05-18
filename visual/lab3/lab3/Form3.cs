using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form3 : Form
    {
        Form2 form2;
        public Form3()
        {
            InitializeComponent();
        }

        public static void Create(Form2 f2)
        {
            Form3 f3 = new Form3();
            f3.form2=f2;
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string color = textBox2.Text;
            int edge;
            float size;
            try
            {
                edge = int.Parse(textBox3.Text);
            }
            catch
            {
                edge = 0;
            }
            try
            {
                size = int.Parse(textBox4.Text);
            }
            catch
            {
                size = 0;
            }
            Shape s = new Shape(name, color, edge, size);
            form2.Add(s);
            this.Close();
        }
    }
}
