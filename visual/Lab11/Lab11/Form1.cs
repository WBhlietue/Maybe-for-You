using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();

        Province[] aimag = new Province[20];
        int filter = 0;
        public Form1()
        {
            InitializeComponent();
            table.Columns.Add("Аймаг", typeof(string));
            table.Columns.Add("Шинэ гарсан тохиолдол", typeof(int));
            table.Columns.Add("Нийт тохиолдол", typeof(int));
            table.Columns.Add("Хуучин тохиолдол", typeof(int));
            table.Columns.Add("Бүс нутаг", typeof(string));

            table2.Columns.Add("Бүс нутаг", typeof(string));
            table2.Columns.Add("Аймгууд", typeof(int));
            table2.Columns.Add("Нийт шинэ тохиолдол", typeof(long));
            table2.Columns.Add("Дундажаар нийт тохиолдол", typeof(long));
            filterOption.SelectedIndex = 0;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int ctr = 0; ctr < aimag.Length; ctr++)
            {
                aimag[ctr] = new Province();
            }
            aimag[0].pName = "ДАРХАН";
            aimag[0].nCase = 14;
            aimag[0].oCase = 222;
            aimag[0].pRegion = "Төвийн бүс";
            aimag[1].pName = "ЭРДЭНЭТ";
            aimag[1].nCase = 28;
            aimag[1].oCase = 251;
            aimag[1].pRegion = "Говийн бүс";
            aimag[2].pName = "УЛААНБААТАР";
            aimag[2].nCase = 654;
            aimag[2].oCase = 15739;
            aimag[2].pRegion = "Төвийн бүс";
            aimag[3].pName = "Хөвсгөл";
            aimag[3].nCase = 1;
            aimag[3].oCase = 53;
            aimag[3].pRegion = "Говийн бүс";
            aimag[4].pName = "Увс";
            aimag[4].nCase = 1;
            aimag[4].oCase = 7;
            aimag[4].pRegion = "Баруун бүс";
            aimag[5].pName = "БАЯН-Өлгий";
            aimag[5].nCase = 0;
            aimag[5].oCase = 2;
            aimag[5].pRegion = "Баруун бүс";
            aimag[6].pName = "СЭЛЭНГЭ";
            aimag[6].nCase = 6;
            aimag[6].oCase = 342;
            aimag[6].pRegion = "Төвийн бүс";
            aimag[7].pName = "Завхан";
            aimag[7].nCase = 4;
            aimag[7].oCase = 19;
            aimag[7].pRegion = "Баруун бүс";
            aimag[8].pName = "БУЛГАН";
            aimag[8].nCase = 0;
            aimag[8].oCase = 72;
            aimag[8].pRegion = "Говийн бүс";
            aimag[9].pName = "Хэнтий";
            aimag[9].nCase = 4;
            aimag[9].oCase = 27;
            aimag[9].pRegion = "Зүүн бүс";
            aimag[10].pName = "Ховд";
            aimag[10].nCase = 5;
            aimag[10].oCase = 148;
            aimag[10].pRegion = "Баруун бүс";
            aimag[11].pName = "АРХАНГАЙ";
            aimag[11].nCase = 6;
            aimag[11].oCase = 222;
            aimag[11].pRegion = "Говийн бүс";
            aimag[12].pName = "Төв";
            aimag[12].nCase = 10;
            aimag[12].oCase = 451;
            aimag[12].pRegion = "Төвийн бүс";
            aimag[13].pName = "ДОРНОД";
            aimag[13].nCase = 0;
            aimag[13].oCase = 4;
            aimag[13].pRegion = "Зүүн бүс";
            aimag[14].pName = "БАЯНХОНГОР";
            aimag[14].nCase = 0;
            aimag[14].oCase = 65;
            aimag[14].pRegion = "Говийн бүс";
            aimag[15].pName = "Чойр";
            aimag[15].nCase = 3;
            aimag[15].oCase = 31;
            aimag[15].pRegion = "Төвийн бүс";
            aimag[16].pName = "CYXБAATAP";
            aimag[16].nCase = 2;
            aimag[16].oCase = 94;
            aimag[16].pRegion = "Зүүн бүс";
            aimag[17].pName = "ӨВӨРХАНГАЙ";
            aimag[17].nCase = 0;
            aimag[17].oCase = 179;
            aimag[17].pRegion = "Говийн бүс";
            aimag[18].pName = "ДУНДГОВЬ";
            aimag[18].nCase = 3;
            aimag[18].oCase = 15;
            aimag[18].pRegion = "Төвийн бүс";
            aimag[19].pName = "Дорноговь";
            aimag[19].nCase = 1;
            aimag[19].oCase = 59;
            aimag[19].pRegion = "Төвийн бүс";

            foreach(var item in aimag)
            {
                item.pName = item.pName.ToUpper();
                item.pRegion = item.pRegion.ToUpper();
            }

            display_Click(sender, e);


        }

        private void display_Click(object sender, EventArgs e)
        {
            table.Clear();
            label1.Text = "Бүх мэдээллийг харуулбал...";
            var info = from i in aimag select i;
            foreach (var intr in info)
            {
                table.Rows.Add(intr.pName, intr.nCase, intr.oCase, intr.oCase - intr.nCase,
                intr.pRegion);
            }
            this.dataGridView1.DataSource = table;

        }

        private void sortAsc_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Өсөхөөр эрэмбэлвэл /Шинээр илэрсэн тохиолдлын тоогоор/ ...";
            var info = from i in aimag orderby i.nCase select i;
            table.Clear();
            foreach (var intr in info)
            {
                table.Rows.Add(intr.pName, intr.nCase, intr.oCase, intr.oCase-intr.nCase,
                intr.pRegion);
            }
            dataGridView1.DataSource = table;

        }

        private void sortDes_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Буурахаар эрэмбэлэх /Нийт тохиолдлуудын тоогоор/ ...";
            var info = from i in aimag orderby i.oCase descending select i;
            table.Clear();
            foreach (var intr in info)
            {
                table.Rows.Add(intr.pName, intr.nCase, intr.oCase, intr.oCase - intr.nCase,
                intr.pRegion);
            }
            dataGridView1.DataSource = table;
        }

        private void groupByCon_Click(object sender, EventArgs e)
        {
            table2.Clear();
            this.label1.Text = "Өвчлөлийг бүс нутгаар нь нэгтгэж харвал...";
            var info = from i in aimag
                       group i by i.pRegion into g
                       select new
                       {
                           Region = g.Key,
                           NumberOfProvines = g.Count(),
                           TotalCases = g.Sum(s => s.nCase),
                           AverageCases = g.Average(a =>
                           (a.nCase + a.oCase))
                       };
            foreach (var intr in info)
            {
                table2.Rows.Add(intr.Region, intr.NumberOfProvines,
                intr.TotalCases, intr.AverageCases);
            }
            this.dataGridView1.DataSource = table2;

        }

        private void filterBy_Click(object sender, EventArgs e)
        {
            switch (filter) {
                case 0:
                    this.label1.Text = "Аймгийн нэрээр өвчлөлийн мэдээллийг шүүж харвал...";
                    var info0 = from i in aimag
                               where i.pName == txtBoxAimag.Text.Trim().ToUpper()
                               select i;
                    table.Clear();
                    foreach (var intr in info0)
                    {
                        table.Rows.Add(intr.pName, intr.nCase, intr.oCase, intr.oCase - intr.nCase,
                        intr.pRegion);
                    }
                    this.dataGridView1.DataSource = table;
                    break;
                case 1:
                    this.label1.Text = "Нийт өвчлөлийн тоогоор шүүж харвал...";
                    try
                    {
                        var info1 = from i in aimag
                                    where i.oCase == int.Parse(txtBoxAimag.Text)
                                    select i;
                        table.Clear();
                        foreach (var intr in info1)
                        {
                            table.Rows.Add(intr.pName, intr.nCase, intr.oCase, intr.oCase - intr.nCase,
                            intr.pRegion);
                        }
                        this.dataGridView1.DataSource = table;
                    }
                    catch { }
                    break;
                case 2:
                    this.label1.Text = "Бүс нутгаар шүүж харвал...";
                    var info2 = from i in aimag
                               where i.pRegion == txtBoxAimag.Text.Trim().ToUpper()
                               select i;
                    table.Clear();
                    foreach (var intr in info2)
                    {
                        table.Rows.Add(intr.pName, intr.nCase, intr.oCase, intr.oCase - intr.nCase,
                        intr.pRegion);
                    }
                    this.dataGridView1.DataSource = table;
                    break;
            }
        }

        private void txtBoxAimag_TextChanged(object sender, EventArgs e)
        {

        }

        private void filterOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter = filterOption.SelectedIndex;
        }

        private void sortOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (
            sortOption.SelectedIndex)
            {
                case 0:
                    this.label1.Text = "Өсөхөөр эрэмбэлвэл /Шинээр илэрсэн тохиолдлын тоогоор/ ...";
                     var info = from i in aimag orderby  i.nCase  select i;
                    table.Clear();
                    foreach (var intr in info)
                    {
                        table.Rows.Add(intr.pName, intr.nCase, intr.oCase, intr.oCase - intr.nCase,
                        intr.pRegion);
                    }
                    dataGridView1.DataSource = table;

                    break;
                case 1:
                    this.label1.Text = "Буурахаар эрэмбэлвэл /Шинээр илэрсэн тохиолдлын тоогоор/ ...";
                    var info1 = from i in aimag orderby i.nCase descending select i;
                    table.Clear();
                    foreach (var intr in info1)
                    {
                        table.Rows.Add(intr.pName, intr.nCase, intr.oCase, intr.oCase - intr.nCase,
                        intr.pRegion);
                    }
                    dataGridView1.DataSource = table;
                    break;
                case 2:
                    this.label1.Text = "Өсөхөөр эрэмбэлэх /Нийт тохиолдлуудын тоогоор/ ...";
                    var info2 = from i in aimag orderby i.oCase  select i;
                    table.Clear();
                    foreach (var intr in info2)
                    {
                        table.Rows.Add(intr.pName, intr.nCase, intr.oCase, intr.oCase - intr.nCase,
                        intr.pRegion);
                    }
                    dataGridView1.DataSource = table;
                    break;
                case 3:
                    this.label1.Text = "Буурахаар эрэмбэлэх /Нийт тохиолдлуудын тоогоор/ ...";
                    var info3 = from i in aimag orderby i.oCase descending select i;
                    table.Clear();
                    foreach (var intr in info3)
                    {
                        table.Rows.Add(intr.pName, intr.nCase, intr.oCase, intr.oCase - intr.nCase,
                        intr.pRegion);
                    }
                    dataGridView1.DataSource = table;
                    break;
                case 4:
                    this.label1.Text = "Өсөхөөр эрэмбэлэх /Хуучин тохиолдлуудын тоогоор/ ...";
                    var info4 = from i in aimag orderby (i.oCase - i.nCase) select i;
                    table.Clear();
                    foreach (var intr in info4)
                    {
                        table.Rows.Add(intr.pName, intr.nCase, intr.oCase, intr.oCase - intr.nCase,
                        intr.pRegion);
                    }
                    dataGridView1.DataSource = table;
                    break;
                case 5:
                    this.label1.Text = "Өсөхөөр эрэмбэлэх /Хуучин тохиолдлуудын тоогоор/ ...";
                    var info5 = from i in aimag orderby (i.oCase - i.nCase) descending select i;
                    table.Clear();
                    foreach (var intr in info5)
                    {
                        table.Rows.Add(intr.pName, intr.nCase, intr.oCase, intr.oCase - intr.nCase,
                        intr.pRegion);
                    }
                    dataGridView1.DataSource = table;
                    break;
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Хамгийн өндөр 5 /Нийт тохиолдлуудын тоогоор/ ...";
            var info3 = from i in aimag orderby i.oCase descending select i;
            table.Clear();
            int a = 0;
            foreach (var intr in info3)
            {if(a >= 5)
                    {
                        return;
                    }
                a++;
                table.Rows.Add(intr.pName, intr.nCase, intr.oCase, intr.oCase - intr.nCase,
                intr.pRegion);
            }
            dataGridView1.DataSource = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = aimag.Select(i => i.oCase).Sum();
            MessageBox.Show(sum+"");
        }
    }
}
