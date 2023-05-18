using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab2
{
    public partial class Form1 : Form
    {
        CustomerManager manager;
        public Form1()
        {
            manager = new CustomerManager();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void LogIn()
        {
            string name = inputUserName.Text;
            string pass = inputPass.Text;
            if(name == "")
            {
                MessageBox.Show("name must not be empty");
                return;
            }
            if (pass == "")
            {
                MessageBox.Show("pass must not be empty");
                return;
            }
            manager.Login(name, pass, (Customer cus) => { LoggedComplete(cus); });
        }
        void LoggedComplete(Customer cus)
        {
            MessageBox.Show("Logged");
        }


        private void btnSign_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }
    }

    class CustomerManager
    {
        List<Customer> customers;
        public static CustomerManager instance;
        public CustomerManager()
        {
            instance = this;
            customers = new List<Customer>();
            Load();
        }
        public void Load()
        {
            try
            {
                StreamReader reader = new StreamReader("../../data.txt");
                string line = reader.ReadLine();
                while (line != null)
                {
                    try
                    {
                        customers.Add(Customer.FromString(line));
                    }
                    catch { }
                    line = reader.ReadLine();
                }
                reader.Close();
            }
            catch { }
        }
        public void Save()
        {
            try
            {
                StreamWriter write = new StreamWriter("../../data.txt");
                foreach (var item in customers)
                {
                    try
                    {
                        write.WriteLine(item.ToString());
                    }
                    catch { }
                }
                write.Close();
            }
            catch { }
        }
        public void Login(string name, string pass, Action<Customer> complete)
        {
            foreach (var item in customers)
            {
                if (item.LoginStatus(name, pass) == "Complete")
                {
                    complete(item);
                    return;
                }
                else if (item.LoginStatus(name, pass) == "Wrong password")
                {
                    MessageBox.Show("Wrong password");
                    return;
                }
            }
            MessageBox.Show("Fail! No matched username");
        }
        public string Register(Customer cus)
        {
            foreach(var item in customers)
            {
                if(item.name == cus.name)
                {
                    return "Same name";
                }
            }
            customers.Add(cus);
            Save();
            return "complete";
        }

    }

    class Customer
    {
        public string name;
        private string password;
        private string adress;
        private string hiredDate;
        private string degree;
        private string depart;
        public Customer(string n, string p, string a, string h, string d, string dep)
        {
            name = n;
            password = p;
            adress = a;
            hiredDate = h;
            degree = d;
            depart = dep;
        }
        public override string ToString()
        {
            return name+"`"+password+"`"+adress+"`"+hiredDate+"`"+degree+"`"+depart;
        }
        public static Customer FromString(string str)
        {
            string[] s = str.Split('`');
            return new Customer(s[0], s[1], s[2], s[3], s[4], s[5]);
        }
        public string LoginStatus(string n, string p)
        {
            if(n == name)
            {
                if(p == password)
                {
                    return "Complete";
                }
                else
                {
                    return "Wrong password";
                }
            }
            else
            {
                return "";
            }
        }
    }




}
