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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void Set(Shape s)
        {
            Form1 f = new Form1();
            f.nameText.Text = "Name: " + s.name;
            f.colorText.Text = "Color: " + s.color;
            f.edgeText.Text = "Edge number: " + s.edge;
            f.sizeText.Text = "Edge length: " + s.edgeLength;
            f.pText.Text = "Perimetr: " + s.GetPerimetr();
            f.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameText_Click(object sender, EventArgs e)
        {

        }

        private void edgeText_Click(object sender, EventArgs e)
        {

        }

        private void sizeText_Click(object sender, EventArgs e)
        {

        }

        private void colorText_Click(object sender, EventArgs e)
        {

        }
    }
    public class Shape
    {
        public string name;
        public string color;
        public int edge;
        public float edgeLength;
        public float perimetr;
        public Shape(string n, string c, int e, float s)
        {
            name = n;
            color = c;
            edge = e;
            edgeLength = s;
        }

        public float GetPerimetr()
        {
            return edge * edgeLength;
        }

    }
}
