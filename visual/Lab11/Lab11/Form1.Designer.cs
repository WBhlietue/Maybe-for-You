namespace Lab11
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBoxAimag = new System.Windows.Forms.TextBox();
            this.sortOption = new System.Windows.Forms.ComboBox();
            this.filterOption = new System.Windows.Forms.ComboBox();
            this.display = new System.Windows.Forms.Button();
            this.sortAsc = new System.Windows.Forms.Button();
            this.sortDes = new System.Windows.Forms.Button();
            this.filterBy = new System.Windows.Forms.Button();
            this.groupByCon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "...";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(782, 315);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtBoxAimag
            // 
            this.txtBoxAimag.Location = new System.Drawing.Point(800, 318);
            this.txtBoxAimag.Name = "txtBoxAimag";
            this.txtBoxAimag.Size = new System.Drawing.Size(199, 22);
            this.txtBoxAimag.TabIndex = 2;
            this.txtBoxAimag.TextChanged += new System.EventHandler(this.txtBoxAimag_TextChanged);
            // 
            // sortOption
            // 
            this.sortOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortOption.FormattingEnabled = true;
            this.sortOption.Items.AddRange(new object[] {
            "Шинэ гарсан өвчлөлийн тоогоор ^",
            "Шинэ гарсан өвчлөлийн тоогоор v",
            "Нийт өвчлөлийн тоогоор ^",
            "Нийт өвчлөлийн тоогоор v",
            "Хуучин өвчлөлийн тоогоор ^",
            "Хуучин өвчлөлийн тоогоор v"});
            this.sortOption.Location = new System.Drawing.Point(870, 78);
            this.sortOption.Name = "sortOption";
            this.sortOption.Size = new System.Drawing.Size(284, 24);
            this.sortOption.TabIndex = 3;
            this.sortOption.SelectedIndexChanged += new System.EventHandler(this.sortOption_SelectedIndexChanged);
            // 
            // filterOption
            // 
            this.filterOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterOption.FormattingEnabled = true;
            this.filterOption.Items.AddRange(new object[] {
            "Аймгийн нэрээр",
            "Нийт өвчлөлийн тоогоор",
            "Бүсчлэлээр"});
            this.filterOption.Location = new System.Drawing.Point(870, 108);
            this.filterOption.Name = "filterOption";
            this.filterOption.Size = new System.Drawing.Size(284, 24);
            this.filterOption.TabIndex = 4;
            this.filterOption.SelectedIndexChanged += new System.EventHandler(this.filterOption_SelectedIndexChanged);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(800, 158);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(404, 23);
            this.display.TabIndex = 5;
            this.display.Text = "Өвчлөлийн тоог харуулах";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // sortAsc
            // 
            this.sortAsc.Location = new System.Drawing.Point(800, 196);
            this.sortAsc.Name = "sortAsc";
            this.sortAsc.Size = new System.Drawing.Size(404, 23);
            this.sortAsc.TabIndex = 6;
            this.sortAsc.Text = "Өсөхөөр эрэмбэлэх /Шинэ тохиолдлуудын тоогоор/";
            this.sortAsc.UseVisualStyleBackColor = true;
            this.sortAsc.Click += new System.EventHandler(this.sortAsc_Click);
            // 
            // sortDes
            // 
            this.sortDes.Location = new System.Drawing.Point(800, 235);
            this.sortDes.Name = "sortDes";
            this.sortDes.Size = new System.Drawing.Size(404, 23);
            this.sortDes.TabIndex = 7;
            this.sortDes.Text = "Буурахаар эрэмбэлэх /Нийт тохиолдлуудын тоогоор/";
            this.sortDes.UseVisualStyleBackColor = true;
            this.sortDes.Click += new System.EventHandler(this.sortDes_Click);
            // 
            // filterBy
            // 
            this.filterBy.Location = new System.Drawing.Point(1015, 317);
            this.filterBy.Name = "filterBy";
            this.filterBy.Size = new System.Drawing.Size(189, 23);
            this.filterBy.TabIndex = 8;
            this.filterBy.Text = " Шүүж харах";
            this.filterBy.UseVisualStyleBackColor = true;
            this.filterBy.Click += new System.EventHandler(this.filterBy_Click);
            // 
            // groupByCon
            // 
            this.groupByCon.Location = new System.Drawing.Point(800, 275);
            this.groupByCon.Name = "groupByCon";
            this.groupByCon.Size = new System.Drawing.Size(404, 23);
            this.groupByCon.TabIndex = 8;
            this.groupByCon.Text = "Өвчлөлийг бүсчлэлээр харуулах";
            this.groupByCon.UseVisualStyleBackColor = true;
            this.groupByCon.Click += new System.EventHandler(this.groupByCon_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(800, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(404, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Хамгийн өндөр 5";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(800, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(404, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Нийт ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupByCon);
            this.Controls.Add(this.filterBy);
            this.Controls.Add(this.sortDes);
            this.Controls.Add(this.sortAsc);
            this.Controls.Add(this.display);
            this.Controls.Add(this.filterOption);
            this.Controls.Add(this.sortOption);
            this.Controls.Add(this.txtBoxAimag);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Коронавирус халдварын";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBoxAimag;
        private System.Windows.Forms.ComboBox sortOption;
        private System.Windows.Forms.ComboBox filterOption;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Button sortAsc;
        private System.Windows.Forms.Button sortDes;
        private System.Windows.Forms.Button filterBy;
        private System.Windows.Forms.Button groupByCon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

