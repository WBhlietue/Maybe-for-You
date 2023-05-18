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

namespace lab5
{
    public partial class Form2 : Form
    {
        Form1 f;
        string[] hoolname, salatName;
        Food food;
        int num = 0;
        int remove = -1;
        FoodSize rm;
        public Form2(Form1 f, Order order)
        {
            InitializeComponent();
            this.f = f;
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            foreach (var item in f.reg.foodList)
            {
                if (item.fType == FoodType.Hool)
                {
                    list1.Add(item.name);
                }
                else
                {
                    list2.Add(item.name);
                }
            }
            hoolname = list1.ToArray();
            salatName = list2.ToArray();
            comboBox2.SelectedIndexChanged += SetPrice;
            comboBox3.SelectedIndexChanged += SetPrice;
            if (order == null)
            {
                comboBox1.Text = comboBox1.Items[0].ToString();
                comboBox3.Text = comboBox3.Items[0].ToString();
                food = null;
                remove = -1;
                num = 0;
                textBox1.Text = "0";
            }
            else
            {
                remove = f.reg.GetFoodNum(order.food);
                rm = order.food.fSize;
                comboBox1.Text = comboBox1.Items[(int)order.food.fType].ToString();
                comboBox2.Text = order.food.name;
                comboBox3.Text = order.food.fSize.ToString();
                food = order.food;
                num = order.num;
                textBox1.Text = num + "";
            }
        }
       
        public static void ShowWindow(Form1 f1, Order order = null)
        {
            new Form2(f1, order).Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.Text == comboBox1.Items[0].ToString())
            {
                comboBox2.Items.AddRange(hoolname);
            }
            else
            {
                comboBox2.Items.AddRange(salatName);
            }
            comboBox2.Text = comboBox2.Items[0].ToString();
            SetPrice(null, null);
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
            SetPrice(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (remove >= 0)
            {
                f.reg.RemoveOrder(remove, rm);
            }
            f.GetFromForm2(food, num, remove);
            this.Close();
        }

        void SetPrice(object render, EventArgs e)
        {
            foreach (var item in f.reg.foodList)
            {
                if (item.name == comboBox2.Text && (int)item.fType == comboBox1.SelectedIndex)
                {
                    food = item.GetFood(FoodRegister.ConvertSize(comboBox3.Text));
                    label5.Text = "Дүн: " + (food.price * num) + "₮";
                    return;
                }
            }
        }

    }
}
