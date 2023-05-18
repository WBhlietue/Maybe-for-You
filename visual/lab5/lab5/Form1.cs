using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public FoodRegister reg = new FoodRegister();
        public Form1()
        {
            InitializeComponent();
            Set();
        }

        void Set()
        {
            tableLayoutPanel1.Controls.Clear();
            string[] colNames = new string[] { "Код", "Нэр", "Хэмжээ", "Төрөл", "Үнэ", "Тоо", "Дүн", "", "" };
            for (int i = 0; i < colNames.Length; i++)
            {
                Label label = GetLabel(colNames[i]);
                tableLayoutPanel1.Controls.Add(label, i, 0);

            }
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.Size = new Size(600, (reg.ordered.Count + 1) * 40);
            for (int i = 0; i < reg.ordered.Count; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
                Label nameLabel = GetLabel(reg.ordered[i].food.name);
                Label typeLabel = GetLabel(reg.ordered[i].food.fType.ToString());
                string si;
                switch (reg.ordered[i].food.fSize)
                {
                    case FoodSize.Medium:
                        si = "Дунд";
                        break;
                    case FoodSize.Half:
                        si = "Жижиг";
                        break;
                    case FoodSize.Full:
                        si = "Том";
                        break;
                    default:
                        si = "None";
                        break;
                }
                Label sizeLabel = GetLabel(si);
                Label priceLabel = GetLabel(reg.ordered[i].food.price + "");
                Label numberLabel = GetLabel(reg.ordered[i].num + "");
                Label totalLabel = GetLabel((reg.ordered[i].food.price * reg.ordered[i].num) + "");
                int a = reg.GetFoodNum(reg.ordered[i].food);
                Label numLabel = GetLabel(a + "");
                Button btn1 = GetButton("Өөрчлөх");
                Button btn2 = GetButton("Устгах");
                int n = i;
                btn1.Click += (object sender, EventArgs e) =>
                {
                    try
                    {
                        Form2.ShowWindow(this, reg.ordered[n]);
                    }
                    catch {
                    }
                };
                btn2.Click += (object sender, EventArgs e) =>
                {
                    reg.RemoveOrder(a, FoodRegister.ConvertSize(sizeLabel.Text));
                    Set();
                };
                tableLayoutPanel1.Controls.Add(numLabel, 0, i + 1);
                tableLayoutPanel1.Controls.Add(nameLabel, 1, i + 1);
                tableLayoutPanel1.Controls.Add(sizeLabel, 2, i + 1);
                tableLayoutPanel1.Controls.Add(typeLabel, 3, i + 1);
                tableLayoutPanel1.Controls.Add(priceLabel, 4, i + 1);
                tableLayoutPanel1.Controls.Add(numberLabel, 5, i + 1);
                tableLayoutPanel1.Controls.Add(totalLabel, 6, i + 1);
                tableLayoutPanel1.Controls.Add(btn1, 7, i + 1);
                tableLayoutPanel1.Controls.Add(btn2, 8, i + 1);

            }
            int h = 0;
            int s = 0;
            int total = 0;
            foreach(var item in reg.ordered)
            {
                if(item.food.fType == FoodType.Hool)
                {
                    h+=item.num;
                }
                else
                {
                    s+=item.num;
                }
                total += item.price;
            }
            if(h == 2 && s == 1)
            {
                total = total * 97 / 100;
            }else if(h == 2 && s == 2)
            {
                total = total * 95 / 100;
            }
            if(total >= 320000)
            {
                total = total * 9 / 10;
            }
            label2.Text = "Дүн: " + total + "₮";
        }

        Label GetLabel(string text)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label.Location = new Point(3, 0);
            label.Name = "label2";
            label.Size = new Size(44, 16);
            label.TabIndex = 0;
            label.Text = text;
            return label;
        }

        Button GetButton(string text)
        {
            Button label = new Button();
            label.AutoSize = true;
            label.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            label.Location = new Point(3, 0);
            label.Name = "label2";
            label.TabIndex = 0;
            label.Text = text;
            return label;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Result(reg).Show();
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2.ShowWindow(this);
        }

        public void GetFromForm2(Food d, int num, int remove = -1)
        {
            
            reg.AddOrder(reg.GetFoodNum(d), d.fSize, num);
            Set();
        }
    }
}
