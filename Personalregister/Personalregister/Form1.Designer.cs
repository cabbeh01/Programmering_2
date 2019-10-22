namespace Personalregister
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
            this.tbxNameVender = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxProvisionVender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSalesVender = new System.Windows.Forms.TextBox();
            this.btnRegisterSales = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRegisterShift = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxTimeWorkedConsultant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxHourlyConsultant = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxNameConsultant = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRegisterIncome = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxIncomeClerk = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxNameClerk = new System.Windows.Forms.TextBox();
            this.lbxRegister = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbxPayout = new System.Windows.Forms.ListBox();
            this.btnCalculateIncome = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxTotalSalary = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegisterSales);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxSalesVender);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxProvisionVender);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxNameVender);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Säljare";
            // 
            // tbxNameVender
            // 
            this.tbxNameVender.Location = new System.Drawing.Point(98, 32);
            this.tbxNameVender.Name = "tbxNameVender";
            this.tbxNameVender.Size = new System.Drawing.Size(94, 20);
            this.tbxNameVender.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Provision";
            // 
            // tbxProvisionVender
            // 
            this.tbxProvisionVender.Location = new System.Drawing.Point(98, 58);
            this.tbxProvisionVender.Name = "tbxProvisionVender";
            this.tbxProvisionVender.Size = new System.Drawing.Size(94, 20);
            this.tbxProvisionVender.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Försäljning";
            // 
            // tbxSalesVender
            // 
            this.tbxSalesVender.Location = new System.Drawing.Point(98, 84);
            this.tbxSalesVender.Name = "tbxSalesVender";
            this.tbxSalesVender.Size = new System.Drawing.Size(94, 20);
            this.tbxSalesVender.TabIndex = 4;
            // 
            // btnRegisterSales
            // 
            this.btnRegisterSales.Location = new System.Drawing.Point(25, 143);
            this.btnRegisterSales.Name = "btnRegisterSales";
            this.btnRegisterSales.Size = new System.Drawing.Size(167, 23);
            this.btnRegisterSales.TabIndex = 6;
            this.btnRegisterSales.Text = "Registrera försäljning";
            this.btnRegisterSales.UseVisualStyleBackColor = true;
            this.btnRegisterSales.Click += new System.EventHandler(this.BtnRegisterSales_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRegisterShift);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbxTimeWorkedConsultant);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbxHourlyConsultant);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbxNameConsultant);
            this.groupBox2.Location = new System.Drawing.Point(239, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 182);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Konsult";
            // 
            // btnRegisterShift
            // 
            this.btnRegisterShift.Location = new System.Drawing.Point(25, 143);
            this.btnRegisterShift.Name = "btnRegisterShift";
            this.btnRegisterShift.Size = new System.Drawing.Size(167, 23);
            this.btnRegisterShift.TabIndex = 6;
            this.btnRegisterShift.Text = "Registrera arbetspass";
            this.btnRegisterShift.UseVisualStyleBackColor = true;
            this.btnRegisterShift.Click += new System.EventHandler(this.BtnRegisterShift_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Arbetad tid";
            // 
            // tbxTimeWorkedConsultant
            // 
            this.tbxTimeWorkedConsultant.Location = new System.Drawing.Point(106, 84);
            this.tbxTimeWorkedConsultant.Name = "tbxTimeWorkedConsultant";
            this.tbxTimeWorkedConsultant.Size = new System.Drawing.Size(86, 20);
            this.tbxTimeWorkedConsultant.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Timlön";
            // 
            // tbxHourlyConsultant
            // 
            this.tbxHourlyConsultant.Location = new System.Drawing.Point(106, 58);
            this.tbxHourlyConsultant.Name = "tbxHourlyConsultant";
            this.tbxHourlyConsultant.Size = new System.Drawing.Size(86, 20);
            this.tbxHourlyConsultant.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Namn";
            // 
            // tbxNameConsultant
            // 
            this.tbxNameConsultant.Location = new System.Drawing.Point(106, 32);
            this.tbxNameConsultant.Name = "tbxNameConsultant";
            this.tbxNameConsultant.Size = new System.Drawing.Size(86, 20);
            this.tbxNameConsultant.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRegisterIncome);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbxIncomeClerk);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbxNameClerk);
            this.groupBox3.Location = new System.Drawing.Point(466, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 182);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kontorist";
            // 
            // btnRegisterIncome
            // 
            this.btnRegisterIncome.Location = new System.Drawing.Point(25, 143);
            this.btnRegisterIncome.Name = "btnRegisterIncome";
            this.btnRegisterIncome.Size = new System.Drawing.Size(167, 23);
            this.btnRegisterIncome.TabIndex = 6;
            this.btnRegisterIncome.Text = "Registrera månadslön";
            this.btnRegisterIncome.UseVisualStyleBackColor = true;
            this.btnRegisterIncome.Click += new System.EventHandler(this.BtnRegisterIncome_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Månadslön";
            // 
            // tbxIncomeClerk
            // 
            this.tbxIncomeClerk.Location = new System.Drawing.Point(92, 58);
            this.tbxIncomeClerk.Name = "tbxIncomeClerk";
            this.tbxIncomeClerk.Size = new System.Drawing.Size(100, 20);
            this.tbxIncomeClerk.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Namn";
            // 
            // tbxNameClerk
            // 
            this.tbxNameClerk.Location = new System.Drawing.Point(92, 32);
            this.tbxNameClerk.Name = "tbxNameClerk";
            this.tbxNameClerk.Size = new System.Drawing.Size(100, 20);
            this.tbxNameClerk.TabIndex = 0;
            // 
            // lbxRegister
            // 
            this.lbxRegister.FormattingEnabled = true;
            this.lbxRegister.Location = new System.Drawing.Point(12, 239);
            this.lbxRegister.Name = "lbxRegister";
            this.lbxRegister.Size = new System.Drawing.Size(192, 199);
            this.lbxRegister.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "REGISTER";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(270, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "LÖNEUTBETALNINGAR";
            // 
            // lbxPayout
            // 
            this.lbxPayout.FormattingEnabled = true;
            this.lbxPayout.Location = new System.Drawing.Point(240, 239);
            this.lbxPayout.Name = "lbxPayout";
            this.lbxPayout.Size = new System.Drawing.Size(192, 199);
            this.lbxPayout.TabIndex = 10;
            // 
            // btnCalculateIncome
            // 
            this.btnCalculateIncome.Location = new System.Drawing.Point(466, 239);
            this.btnCalculateIncome.Name = "btnCalculateIncome";
            this.btnCalculateIncome.Size = new System.Drawing.Size(221, 23);
            this.btnCalculateIncome.TabIndex = 7;
            this.btnCalculateIncome.Text = "Beräkna löner";
            this.btnCalculateIncome.UseVisualStyleBackColor = true;
            this.btnCalculateIncome.Click += new System.EventHandler(this.BtnCalculateIncome_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(463, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Total lönekostnad";
            // 
            // tbxTotalSalary
            // 
            this.tbxTotalSalary.Location = new System.Drawing.Point(466, 298);
            this.tbxTotalSalary.Name = "tbxTotalSalary";
            this.tbxTotalSalary.Size = new System.Drawing.Size(221, 20);
            this.tbxTotalSalary.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnCalculateIncome);
            this.Controls.Add(this.tbxTotalSalary);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbxPayout);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbxRegister);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegisterSales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSalesVender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxProvisionVender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNameVender;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRegisterShift;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxTimeWorkedConsultant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxHourlyConsultant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxNameConsultant;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRegisterIncome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxIncomeClerk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxNameClerk;
        private System.Windows.Forms.ListBox lbxRegister;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbxPayout;
        private System.Windows.Forms.Button btnCalculateIncome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxTotalSalary;
    }
}

