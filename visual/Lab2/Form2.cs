using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(inputUserName.Text == "")
            {
                MessageBox.Show("user name is empty");
                return;
            }
            if (inputPass.Text == "")
            {
                MessageBox.Show("pass is empty");
                return;
            }
            if (inputDate.Text == "")
            {
                MessageBox.Show("date is empty");
                return;
            }
            if (inputDegree.Text == "")
            {
                MessageBox.Show("degree is empty");
                return;
            }
            if (inputDepart.Text == "")
            {
                MessageBox.Show("depart is empty");
                return;
            }
            Customer cus = new Customer(inputUserName.Text, inputPass.Text, inputAdress.Text, 
                inputDate.Text, inputDegree.Text, inputDepart.Text);
            string sattus = CustomerManager.instance.Register(cus);
            if(sattus == "complete")
            {
                this.Close();
            }
            else
            {
                status.Text = sattus;
            }
            
        }

        private void inputPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputUserName.Text = "";
            inputPass.Text = "";
            inputAdress.Text = "";
            inputDate.Text = "";
            inputDegree.Text = "";
            inputDepart.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
