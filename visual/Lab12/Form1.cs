using System.Threading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        const int radius = 10;
        const int duration = 500;
        PaintEventArgs paint = null;
        public bool[] tb = new bool[4] { false, false, false, false };
        List<(Point, Color)> circles = new List<(Point, Color)>();
        int count = 0;
        public Form1()
        {
            instance = this;
            InitializeComponent();
            Label.CheckForIllegalCrossThreadCalls = false;
            FlowLayoutPanel.CheckForIllegalCrossThreadCalls = false;
            panel1.Paint += (eventArgs, e) =>
            {
                paint = e;
                Brush b = new SolidBrush(Color.Red);
                Rectangle rec = new Rectangle(0, 0, 400, 300);
                foreach (var item in circles)
                {
                    e.Graphics.DrawEllipse(new Pen(item.Item2), new RectangleF(item.Item1.X, item.Item1.Y, radius, radius));
                }
            };
            List<(Button, int)> list = new List<(Button, int)>{
                (button1, 0),
                (button2, 1),
                (button3, 2),
                (button4, 3),
            };
            List<Action> action = new List<Action>{
                AddRedCircle,AddBlackCircle, AddNumbers, ShowDate
            };
            foreach (var item in list)
            {
                item.Item1.Text = "Thread " + (item.Item2 + 1);
                item.Item1.Click += (a, b) =>
                {
                    if (tb[item.Item2])
                    {
                        tb[item.Item2] = false;
                    }
                    else
                    {
                        new Thread(() =>
                        {
                            tb[item.Item2] = true;
                            while (tb[item.Item2])
                            {
                                action[item.Item2]();
                                panel1.Invalidate();
                                Thread.Sleep(duration);
                            }
                        }).Start();
                    }
                };
            }
        }

        public void AddRedCircle()
        {
            Random r = new Random();
            circles.Add((new Point(r.Next() % 400, r.Next() % 300), Color.Red));
        }
        public void AddBlackCircle()
        {
            Random r = new Random();
            circles.Add((new Point(r.Next() % 400, r.Next() % 300), Color.Black));
        }
        public void AddNumbers()
        {
            Label l = new Label();
            count++;
            l.Text = count + "";
            l.Font = button1.Font;
            BeginInvoke((Action)(() =>
            {

                flowLayoutPanel1.Controls.Add(l);
            }));
        }
        public void ShowDate()
        {
            BeginInvoke((Action)(() =>
            {
                DateTime d = DateTime.Now;
                label1.Text = d.Hour + ":" + d.Minute + ":" + d.Second;
            }));
        }
    }
}
