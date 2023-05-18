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
    public partial class Form2 : Form
    {
        List<Shape> shapes = new List<Shape>();
        public Form2()
        {
            InitializeComponent();
            shapes.Add(new Shape("triangle", "red", 3, 2.4f));
            shapes.Add(new Shape("rectangle", "blue", 4, 6.5f));
            shapes.Add(new Shape("octogram", "yellow", 8, 0.4f));
            shapes.Add(new Shape("line", "green", 1, 10));
            SetButtons();
        }

        void SetButtons()
        {
            Font f = new Font("Arial", 20);
            for (int i = 0; i < shapes.Count; i++)
            {
                Button b = new Button();
                b.Font = f;
                b.Size = new System.Drawing.Size(400, 60);
                b.Text = shapes[i].name;
                b.Click += (object sender, EventArgs e) =>
                {
                    Form1.Set(shapes[flowLayoutPanel1.Controls.IndexOf(b)]);
                };
                flowLayoutPanel1.Controls.Add(b);
            }
            flowLayoutPanel1.AutoScroll = true;
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3.Create(this);
        }
        public void Add(Shape s)
        {
            shapes.Add(s);
            flowLayoutPanel1.Controls.Clear();
            SetButtons();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
