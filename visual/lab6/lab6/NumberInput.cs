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
    public partial class NumberInput : UserControl
    {
        int num = 0;
        public string labelText
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
        public int inputText
        {
            get
            {
                return num;
            }
            set
            {
                textBox1.Text = value.ToString();
            }
        }
        public NumberInput()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                num = int.Parse(textBox1.Text);
                textBox1.Text = num + "";
            }
            catch
            {
                if (textBox1.Text.Length == 0)
                {
                    textBox1.Text = "0";
                }
                else
                {
                    textBox1.Text = num + "";
                }
            }
            textBox1.SelectionStart = textBox1.Text.Length;
        }
    }
}
