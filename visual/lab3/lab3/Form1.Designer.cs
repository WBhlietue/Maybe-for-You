namespace lab3
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.nameText = new System.Windows.Forms.Label();
            this.colorText = new System.Windows.Forms.Label();
            this.edgeText = new System.Windows.Forms.Label();
            this.sizeText = new System.Windows.Forms.Label();
            this.pText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameText
            // 
            this.nameText.AutoSize = true;
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(35, 29);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(127, 42);
            this.nameText.TabIndex = 0;
            this.nameText.Text = "Name:";
            this.nameText.Click += new System.EventHandler(this.nameText_Click);
            // 
            // colorText
            // 
            this.colorText.AutoSize = true;
            this.colorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorText.Location = new System.Drawing.Point(35, 115);
            this.colorText.Name = "colorText";
            this.colorText.Size = new System.Drawing.Size(107, 42);
            this.colorText.TabIndex = 1;
            this.colorText.Text = "Color";
            this.colorText.Click += new System.EventHandler(this.colorText_Click);
            // 
            // edgeText
            // 
            this.edgeText.AutoSize = true;
            this.edgeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeText.Location = new System.Drawing.Point(35, 204);
            this.edgeText.Name = "edgeText";
            this.edgeText.Size = new System.Drawing.Size(106, 42);
            this.edgeText.TabIndex = 2;
            this.edgeText.Text = "Edge";
            this.edgeText.Click += new System.EventHandler(this.edgeText_Click);
            // 
            // sizeText
            // 
            this.sizeText.AutoSize = true;
            this.sizeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeText.Location = new System.Drawing.Point(35, 285);
            this.sizeText.Name = "sizeText";
            this.sizeText.Size = new System.Drawing.Size(91, 42);
            this.sizeText.TabIndex = 3;
            this.sizeText.Text = "Size";
            this.sizeText.Click += new System.EventHandler(this.sizeText_Click);
            // 
            // pText
            // 
            this.pText.AutoSize = true;
            this.pText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pText.Location = new System.Drawing.Point(35, 370);
            this.pText.Name = "pText";
            this.pText.Size = new System.Drawing.Size(157, 42);
            this.pText.TabIndex = 4;
            this.pText.Text = "Perimetr";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(276, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pText);
            this.Controls.Add(this.sizeText);
            this.Controls.Add(this.edgeText);
            this.Controls.Add(this.colorText);
            this.Controls.Add(this.nameText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.Label colorText;
        private System.Windows.Forms.Label edgeText;
        private System.Windows.Forms.Label sizeText;
        private System.Windows.Forms.Label pText;
        private System.Windows.Forms.Button button1;
    }
}

