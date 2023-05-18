using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Calculator calc = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_0.Click += OnClick_0;
            btn_1.Click += OnClick_1;
            btn_2.Click += OnClick_2;
            btn_3.Click += OnClick_3;
            btn_4.Click += OnClick_4;
            btn_5.Click += OnClick_5;
            btn_6.Click += OnClick_6;
            btn_7.Click += OnClick_7;
            btn_8.Click += OnClick_8;
            btn_9.Click += OnClick_9;
            btn_plus.Click += OnClick_plus;
            btn_minus.Click += OnClick_minus;
            btn_mult.Click += OnClick_mult;
            btn_div.Click += OnClick_div;
            button_power.Click += OnClick_Pow;
            btn_clean.Click += Clean;
            btn_equal.Click += Eq;
            btn_del.Click += Pop;
            button_pm.Click += ChangeMinus;
            button_point.Click += Point;
            button_allClean.Click += ClearAll;
            button_mC.Click += MemoryAdd;
            button_mPlus.Click += MemoryAdd;
            button_mMinus.Click += MemoryMinus;
            button_mR.Click += MemoryRender;
           
            value.Text = "0";
            answer.Text= "0";
        }

        public void OnClick_0(object sender, System.EventArgs e)
        {
            calc.AddNum(0);
            ChangeText();
        }
        public void OnClick_1(object sender, System.EventArgs e)
        {
            calc.AddNum(1);
            ChangeText();
        }
        public void OnClick_2(object sender, System.EventArgs e)
        {
            calc.AddNum(2);
            ChangeText();
        }
        public void OnClick_3(object sender, System.EventArgs e)
        {
            calc.AddNum(3);
            ChangeText();
        }
        public void OnClick_4(object sender, System.EventArgs e)
        {
            calc.AddNum(4);
            ChangeText();
        }
        public void OnClick_5(object sender, System.EventArgs e)
        {
            calc.AddNum(5);
            ChangeText();
        }
        public void OnClick_6(object sender, System.EventArgs e)
        {
            calc.AddNum(6);
            ChangeText();
        }
        public void OnClick_7(object sender, System.EventArgs e)
        {
            calc.AddNum(7);
            ChangeText();
        }
        public void OnClick_8(object sender, System.EventArgs e)
        {
            calc.AddNum(8);
            ChangeText();
        }
        public void OnClick_9(object sender, System.EventArgs e)
        {
            calc.AddNum(9);
            ChangeText();
        }
        public void OnClick_plus(object sender, System.EventArgs e)
        {
            calc.AddOpa('+');
            ChangeText();
        }
        public void OnClick_minus(object sender, System.EventArgs e)
        {
            calc.AddOpa('-');
            ChangeText();
        }
        public void OnClick_mult(object sender, System.EventArgs e)
        {
            calc.AddOpa('*');
            ChangeText();
        }
        public void OnClick_div(object sender, System.EventArgs e)
        {
            calc.AddOpa('/');
            ChangeText();
        }
        public void OnClick_Pow(object sender, System.EventArgs e)
        {
            calc.AddOpa('^');
            ChangeText();
        }
        public void Eq(object sender, System.EventArgs e)
        {
            calc.Eq();
            ChangeText();
        }
        public void Clean(object sender, System.EventArgs e)
        {
            calc.Clean();
            value.Text = "0";
            answer.Text = "0";
        }
        public void Pop(object sender, System.EventArgs e)
        {
            calc.Pop();
            ChangeText();
        }
        public void ChangeMinus(object sender, System.EventArgs e)
        {
            calc.ChangeMinus();
            ChangeText();
        }
        public void ChangeText()
        {
            value.Text = calc.value;
            answer.Text = calc.answer;
        }
        public void Point( object sender, System.EventArgs e)
        {
            calc.Point();
            ChangeText();
        }
        public void ClearAll(object sender, System.EventArgs e)
        {
            calc.ClearAll();
            ChangeText();
        }
        public void MemoryAdd(object sender, System.EventArgs e)
        {
            calc.MemoryAdd();
            ChangeText();
        }
        public void MemoryMinus(object sender, System.EventArgs e)
        {
            calc.MemoryMinus();
            ChangeText();
        }
        public void MemoryRender(object sender, System.EventArgs e)
        {
            value.Text = calc.memory + "";
            answer.Text = calc.memory + "";
            calc.value = calc.memory + "";
            calc.toCalculate = calc.memory + "";
        }
        public void MemoryClear(object sender, System.EventArgs e)
        {
            calc.MemoryClear();
            ChangeText();
        }

        private void answer_TextChanged(object sender, EventArgs e)
        {

        }
    }
    class Calculator
    {
        char[] operators = new char[] { '+', '-', '*', '/', '^' };
        public string value="";
        public string toCalculate = "";
        public double memory = 0;
        public string answer { get { return GetAnswer(toCalculate); } }
        public void MemoryAdd()
        {
            try
            {
                memory += double.Parse(GetAnswer(toCalculate));
            }
            catch { }
        }
        public void MemoryMinus()
        {
            try
            {
                memory -= double.Parse(GetAnswer(toCalculate));
            }
            catch { }
        }
        public void MemoryClear()
        {
            memory = 0;
        }
        public void ClearAll()
        {
            MemoryClear();
            Clean();
        }
        public void AddNum(int a)
        {
            value += a;
            toCalculate = value;
        }
        public void ChangeMinus()
        {
            if(value.Length > 0)
            {
                if (value[0] == '-')
                {
                    value = value.Substring(1, value.Length - 1);
                }
                else
                {
                    value = "-" + value;
                }
            }
            if(toCalculate.Length > 0)
            {
                toCalculate= value;
            }
        }
        public void AddOpa(char c)
        {
            if (operators.Contains(value[value.Length-1])) {
                value = value.Substring(0, value.Length- 1);
            }

            value += c;
            toCalculate = "";
        }
        public void Pop()
        {
            if(value.Length > 1)
            {
                value = value.Substring (0, value.Length-1);
                if (operators.Contains(value[value.Length-1]))
                {
                    toCalculate = "";
                }
                else
                {
                    toCalculate = value;
                }
            }
        }
        public void Clean()
        {
            value = "";
            toCalculate = "";
        }
        public void Eq()
        {
            if(toCalculate != "")
            {
                value = GetAnswer(toCalculate);
                toCalculate = value;
            }
        }
        public static bool IsNum(char c)
        {
            return c <= 57 && c >= 48;
        }
        public void Point()
        {
            List<string> nums = new List<string>();

            String tmp = "";
            for (int i = 0; i < value.Length; i++)
            {
                if (IsNum(value[i]) || value[i] == '.')
                {
                    tmp += value[i];
                    try
                    {
                        if (!IsNum(value[i+1]))
                        {
                            nums.Add(tmp);
                            tmp = "";
                        }
                    }
                    catch (Exception e)
                    {
                        nums.Add(tmp);
                        tmp = "";
                    }
                }
            }
            String last = nums[nums.Count - 1];
            if (last.IndexOf('.') == -1)
            {
                value += ".";
                toCalculate = "";
            }
        }

        public static string GetAnswer(string str)
        {
            if (str=="")
            {
                return "";
            }
            List<string> nums = new List<string>();
            List<char> ope = new List<char>();
            if (str[0] == '-' )
            {
                str = "0" + str;
            }
            string tmp = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (IsNum(str[i]) || str[i] == '.')
                {
                    tmp += str[i];
                    try
                    {
                        if (!IsNum(str[i + 1]) && str[(i + 1)] != '.')
                        {
                            nums.Add(tmp);
                            tmp = "";
                        }
                    }
                    catch (Exception e)
                    {
                        nums.Add(tmp);
                        tmp = "";
                    }
                }
                else
                {
                    ope.Add(str[i]);
                }
            }
            for (int i = 0; i < ope.Count; i++)
            {
                if (ope[i] == '^')
                {
                    nums[i] = Math.Pow(Double.Parse(nums[i]),  Double.Parse(nums[i + 1]) ) + "";
                    ope.RemoveAt(i);
                    nums.RemoveAt(i + 1);
                    i--;
                }
            }
            for (int i = 0; i < ope.Count; i++)
            {
                if (ope[i] == '*')
                {
                    nums[i] = (Double.Parse(nums[i]) * Double.Parse(nums[i + 1]) + "");
                    ope.RemoveAt(i);
                    nums.RemoveAt(i + 1);
                    i--;
                }
                else if (ope[i] == '/')
                {
                    if(nums[i + 1] == "0")
                    {
                        if(nums[i] == "0")
                        {
                            return "NaN";
                        }
                        else
                        {
                            return "Infinity";
                        }
                    }
                    nums[i] = (Double.Parse(nums[i]) / Double.Parse(nums[i + 1]) + "");
                    nums.RemoveAt(i + 1);
                    ope.RemoveAt(i);
                    i--;
                }
            }
            while (ope.Count > 0)
            {
                if (ope[0] == '+')
                {
                    nums[0] =  (Double.Parse(nums[0]) + Double.Parse(nums[1]) + "");
                    nums.RemoveAt(1);
                    ope.RemoveAt(0);
                }
                else if (ope[0] == '-')
                {
                    nums[0]= (Double.Parse(nums[0]) - Double.Parse(nums[1]) + "");
                    nums.RemoveAt(1);
                    ope.RemoveAt(0);
                }
            }
            return nums[0];
        }

    }
}


