namespace Lab2
{
    partial class Form2
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.inputPass = new System.Windows.Forms.TextBox();
            this.inputUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputAdress = new System.Windows.Forms.TextBox();
            this.inputAdressda = new System.Windows.Forms.Label();
            this.inputDate = new System.Windows.Forms.TextBox();
            this.inputDatedsa = new System.Windows.Forms.Label();
            this.inputDegree = new System.Windows.Forms.TextBox();
            this.inputDegreedsa = new System.Windows.Forms.Label();
            this.inputDepartasd = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.inputDepart = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnExit.Location = new System.Drawing.Point(367, 586);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 50);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Гарах";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnLogin.Location = new System.Drawing.Point(13, 586);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(177, 50);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Бүртгүүлэх";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // inputPass
            // 
            this.inputPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inputPass.Location = new System.Drawing.Point(259, 169);
            this.inputPass.Name = "inputPass";
            this.inputPass.PasswordChar = '*';
            this.inputPass.Size = new System.Drawing.Size(231, 36);
            this.inputPass.TabIndex = 11;
            this.inputPass.TextChanged += new System.EventHandler(this.inputPass_TextChanged);
            // 
            // inputUserName
            // 
            this.inputUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inputUserName.Location = new System.Drawing.Point(259, 110);
            this.inputUserName.Name = "inputUserName";
            this.inputUserName.Size = new System.Drawing.Size(231, 36);
            this.inputUserName.TabIndex = 10;
            this.inputUserName.TextChanged += new System.EventHandler(this.inputUserName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(8, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Нууц үг:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(8, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Хэрэглэгчийн хэр:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(106, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ажилчны бүртгэл";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputAdress
            // 
            this.inputAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inputAdress.Location = new System.Drawing.Point(259, 236);
            this.inputAdress.Name = "inputAdress";
            this.inputAdress.Size = new System.Drawing.Size(231, 36);
            this.inputAdress.TabIndex = 15;
            // 
            // inputAdressda
            // 
            this.inputAdressda.AutoSize = true;
            this.inputAdressda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inputAdressda.Location = new System.Drawing.Point(8, 239);
            this.inputAdressda.Name = "inputAdressda";
            this.inputAdressda.Size = new System.Drawing.Size(75, 29);
            this.inputAdressda.TabIndex = 14;
            this.inputAdressda.Text = "Хаяг:";
            // 
            // inputDate
            // 
            this.inputDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inputDate.Location = new System.Drawing.Point(259, 304);
            this.inputDate.Name = "inputDate";
            this.inputDate.Size = new System.Drawing.Size(231, 36);
            this.inputDate.TabIndex = 17;
            // 
            // inputDatedsa
            // 
            this.inputDatedsa.AutoSize = true;
            this.inputDatedsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inputDatedsa.Location = new System.Drawing.Point(8, 307);
            this.inputDatedsa.Name = "inputDatedsa";
            this.inputDatedsa.Size = new System.Drawing.Size(247, 29);
            this.inputDatedsa.TabIndex = 16;
            this.inputDatedsa.Text = "Ажилд орсон огноо:";
            // 
            // inputDegree
            // 
            this.inputDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inputDegree.Location = new System.Drawing.Point(259, 381);
            this.inputDegree.Name = "inputDegree";
            this.inputDegree.Size = new System.Drawing.Size(231, 36);
            this.inputDegree.TabIndex = 19;
            // 
            // inputDegreedsa
            // 
            this.inputDegreedsa.AutoSize = true;
            this.inputDegreedsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inputDegreedsa.Location = new System.Drawing.Point(8, 384);
            this.inputDegreedsa.Name = "inputDegreedsa";
            this.inputDegreedsa.Size = new System.Drawing.Size(146, 29);
            this.inputDegreedsa.TabIndex = 18;
            this.inputDegreedsa.Text = "Боловсрол:";
            // 
            // inputDepartasd
            // 
            this.inputDepartasd.AutoSize = true;
            this.inputDepartasd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inputDepartasd.Location = new System.Drawing.Point(8, 454);
            this.inputDepartasd.Name = "inputDepartasd";
            this.inputDepartasd.Size = new System.Drawing.Size(108, 29);
            this.inputDepartasd.TabIndex = 20;
            this.inputDepartasd.Text = "Салбар:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.status.ForeColor = System.Drawing.Color.Red;
            this.status.Location = new System.Drawing.Point(183, 524);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 29);
            this.status.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(196, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 50);
            this.button1.TabIndex = 23;
            this.button1.Text = "Цэвэрлэх";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputDepart
            // 
            this.inputDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inputDepart.FormattingEnabled = true;
            this.inputDepart.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.inputDepart.Location = new System.Drawing.Point(259, 454);
            this.inputDepart.Name = "inputDepart";
            this.inputDepart.Size = new System.Drawing.Size(231, 37);
            this.inputDepart.TabIndex = 24;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 706);
            this.Controls.Add(this.inputDepart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.inputDepartasd);
            this.Controls.Add(this.inputDegree);
            this.Controls.Add(this.inputDegreedsa);
            this.Controls.Add(this.inputDate);
            this.Controls.Add(this.inputDatedsa);
            this.Controls.Add(this.inputAdress);
            this.Controls.Add(this.inputAdressda);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.inputPass);
            this.Controls.Add(this.inputUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox inputPass;
        private System.Windows.Forms.TextBox inputUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputAdress;
        private System.Windows.Forms.Label inputAdressda;
        private System.Windows.Forms.TextBox inputDate;
        private System.Windows.Forms.Label inputDatedsa;
        private System.Windows.Forms.TextBox inputDegree;
        private System.Windows.Forms.Label inputDegreedsa;
        private System.Windows.Forms.Label inputDepartasd;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox inputDepart;
    }
}