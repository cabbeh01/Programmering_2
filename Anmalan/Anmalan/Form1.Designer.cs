namespace Anmalan
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
            this.rBtnOther = new System.Windows.Forms.RadioButton();
            this.rBtnGirl = new System.Windows.Forms.RadioButton();
            this.rBtnBoy = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.tbxCrime = new System.Windows.Forms.TextBox();
            this.tbxHairColor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxLenght = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSok = new System.Windows.Forms.Button();
            this.tbxSok = new System.Windows.Forms.TextBox();
            this.lds = new System.Windows.Forms.Label();
            this.lbxResult = new System.Windows.Forms.ListBox();
            this.btnPick = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnOther);
            this.groupBox1.Controls.Add(this.rBtnGirl);
            this.groupBox1.Controls.Add(this.rBtnBoy);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnChange);
            this.groupBox1.Controls.Add(this.tbxCrime);
            this.groupBox1.Controls.Add(this.tbxHairColor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbxLenght);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxAge);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ANMÄLAN";
            // 
            // rBtnOther
            // 
            this.rBtnOther.AutoSize = true;
            this.rBtnOther.Location = new System.Drawing.Point(23, 145);
            this.rBtnOther.Name = "rBtnOther";
            this.rBtnOther.Size = new System.Drawing.Size(53, 17);
            this.rBtnOther.TabIndex = 17;
            this.rBtnOther.TabStop = true;
            this.rBtnOther.Text = "Annat";
            this.rBtnOther.UseVisualStyleBackColor = true;
            // 
            // rBtnGirl
            // 
            this.rBtnGirl.AutoSize = true;
            this.rBtnGirl.Location = new System.Drawing.Point(111, 125);
            this.rBtnGirl.Name = "rBtnGirl";
            this.rBtnGirl.Size = new System.Drawing.Size(42, 17);
            this.rBtnGirl.TabIndex = 16;
            this.rBtnGirl.TabStop = true;
            this.rBtnGirl.Text = "Tjej";
            this.rBtnGirl.UseVisualStyleBackColor = true;
            // 
            // rBtnBoy
            // 
            this.rBtnBoy.AutoSize = true;
            this.rBtnBoy.Location = new System.Drawing.Point(23, 125);
            this.rBtnBoy.Name = "rBtnBoy";
            this.rBtnBoy.Size = new System.Drawing.Size(44, 17);
            this.rBtnBoy.TabIndex = 15;
            this.rBtnBoy.TabStop = true;
            this.rBtnBoy.Text = "Kille";
            this.rBtnBoy.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(202, 225);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Registrera";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(202, 195);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(167, 23);
            this.btnChange.TabIndex = 13;
            this.btnChange.Text = "Ändra Markerad";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // tbxCrime
            // 
            this.tbxCrime.Location = new System.Drawing.Point(202, 73);
            this.tbxCrime.Multiline = true;
            this.tbxCrime.Name = "tbxCrime";
            this.tbxCrime.Size = new System.Drawing.Size(167, 109);
            this.tbxCrime.TabIndex = 12;
            // 
            // tbxHairColor
            // 
            this.tbxHairColor.Location = new System.Drawing.Point(61, 231);
            this.tbxHairColor.Name = "tbxHairColor";
            this.tbxHairColor.Size = new System.Drawing.Size(100, 20);
            this.tbxHairColor.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Hårfärg";
            // 
            // tbxLenght
            // 
            this.tbxLenght.Location = new System.Drawing.Point(61, 198);
            this.tbxLenght.Name = "tbxLenght";
            this.tbxLenght.Size = new System.Drawing.Size(100, 20);
            this.tbxLenght.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Längd";
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(61, 168);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(100, 20);
            this.tbxAge.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ålder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kön";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(61, 80);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brottsmisstankar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gärningsman";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSok);
            this.groupBox2.Controls.Add(this.tbxSok);
            this.groupBox2.Controls.Add(this.lds);
            this.groupBox2.Location = new System.Drawing.Point(12, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SÖK";
            // 
            // btnSok
            // 
            this.btnSok.Location = new System.Drawing.Point(277, 88);
            this.btnSok.Name = "btnSok";
            this.btnSok.Size = new System.Drawing.Size(75, 23);
            this.btnSok.TabIndex = 15;
            this.btnSok.Text = "Sök";
            this.btnSok.UseVisualStyleBackColor = true;
            this.btnSok.Click += new System.EventHandler(this.BtnSok_Click);
            // 
            // tbxSok
            // 
            this.tbxSok.Location = new System.Drawing.Point(61, 49);
            this.tbxSok.Name = "tbxSok";
            this.tbxSok.Size = new System.Drawing.Size(291, 20);
            this.tbxSok.TabIndex = 16;
            // 
            // lds
            // 
            this.lds.AutoSize = true;
            this.lds.Location = new System.Drawing.Point(20, 52);
            this.lds.Name = "lds";
            this.lds.Size = new System.Drawing.Size(41, 13);
            this.lds.TabIndex = 15;
            this.lds.Text = "Sökord";
            // 
            // lbxResult
            // 
            this.lbxResult.FormattingEnabled = true;
            this.lbxResult.Location = new System.Drawing.Point(423, 95);
            this.lbxResult.Name = "lbxResult";
            this.lbxResult.Size = new System.Drawing.Size(272, 342);
            this.lbxResult.TabIndex = 2;
            // 
            // btnPick
            // 
            this.btnPick.Location = new System.Drawing.Point(457, 53);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(93, 23);
            this.btnPick.TabIndex = 15;
            this.btnPick.Text = "<-- Hämta vald";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.BtnPick_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(590, 53);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Rensa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(463, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 39);
            this.label9.TabIndex = 15;
            this.label9.Text = "Sökresultat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.lbxResult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxHairColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxLenght;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox tbxCrime;
        private System.Windows.Forms.Button btnSok;
        private System.Windows.Forms.TextBox tbxSok;
        private System.Windows.Forms.Label lds;
        private System.Windows.Forms.ListBox lbxResult;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rBtnOther;
        private System.Windows.Forms.RadioButton rBtnGirl;
        private System.Windows.Forms.RadioButton rBtnBoy;
    }
}

