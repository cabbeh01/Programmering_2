namespace Banken
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbxShow = new System.Windows.Forms.ListBox();
            this.btnUpdatewithYearInterest = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSocialNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxInterest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCredit = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWithdraw);
            this.groupBox1.Controls.Add(this.btnDeposit);
            this.groupBox1.Controls.Add(this.tbxAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insättning/Uttag";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbxCredit);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbxInterest);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbxSocialNumber);
            this.groupBox2.Controls.Add(this.btnRegister);
            this.groupBox2.Location = new System.Drawing.Point(256, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 192);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öppna konto";
            // 
            // lbxShow
            // 
            this.lbxShow.FormattingEnabled = true;
            this.lbxShow.Location = new System.Drawing.Point(500, 12);
            this.lbxShow.Name = "lbxShow";
            this.lbxShow.Size = new System.Drawing.Size(241, 160);
            this.lbxShow.TabIndex = 2;
            // 
            // btnUpdatewithYearInterest
            // 
            this.btnUpdatewithYearInterest.Location = new System.Drawing.Point(500, 181);
            this.btnUpdatewithYearInterest.Name = "btnUpdatewithYearInterest";
            this.btnUpdatewithYearInterest.Size = new System.Drawing.Size(241, 23);
            this.btnUpdatewithYearInterest.TabIndex = 3;
            this.btnUpdatewithYearInterest.Text = "Uppdatera med årsränta";
            this.btnUpdatewithYearInterest.UseVisualStyleBackColor = true;
            this.btnUpdatewithYearInterest.Click += new System.EventHandler(this.BtnUpdatewithYearInterest_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(129, 163);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(103, 23);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Registrering";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(80, 19);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(152, 20);
            this.tbxAmount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Belopp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PersonNr";
            // 
            // tbxSocialNumber
            // 
            this.tbxSocialNumber.Location = new System.Drawing.Point(63, 19);
            this.tbxSocialNumber.Name = "tbxSocialNumber";
            this.tbxSocialNumber.Size = new System.Drawing.Size(169, 20);
            this.tbxSocialNumber.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Räntesats";
            // 
            // tbxInterest
            // 
            this.tbxInterest.Location = new System.Drawing.Point(63, 45);
            this.tbxInterest.Name = "tbxInterest";
            this.tbxInterest.Size = new System.Drawing.Size(169, 20);
            this.tbxInterest.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kredit";
            // 
            // tbxCredit
            // 
            this.tbxCredit.Location = new System.Drawing.Point(63, 71);
            this.tbxCredit.Name = "tbxCredit";
            this.tbxCredit.Size = new System.Drawing.Size(169, 20);
            this.tbxCredit.TabIndex = 7;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(129, 134);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(103, 23);
            this.btnDeposit.TabIndex = 9;
            this.btnDeposit.Text = "Insättning";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.BtnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(129, 163);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(103, 23);
            this.btnWithdraw.TabIndex = 10;
            this.btnWithdraw.Text = "Uttag";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.BtnWithdraw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 216);
            this.Controls.Add(this.btnUpdatewithYearInterest);
            this.Controls.Add(this.lbxShow);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Banken";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxCredit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxInterest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSocialNumber;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ListBox lbxShow;
        private System.Windows.Forms.Button btnUpdatewithYearInterest;
    }
}

