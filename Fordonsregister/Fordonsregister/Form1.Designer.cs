namespace Fordonsregister
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbxRegnr = new System.Windows.Forms.TextBox();
            this.tbxBrand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnMC = new System.Windows.Forms.RadioButton();
            this.rbnCar = new System.Windows.Forms.RadioButton();
            this.rbnAll = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilregister";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reg-nr";
            // 
            // tbxRegnr
            // 
            this.tbxRegnr.Location = new System.Drawing.Point(69, 90);
            this.tbxRegnr.Name = "tbxRegnr";
            this.tbxRegnr.Size = new System.Drawing.Size(121, 20);
            this.tbxRegnr.TabIndex = 2;
            // 
            // tbxBrand
            // 
            this.tbxBrand.Location = new System.Drawing.Point(69, 116);
            this.tbxBrand.Name = "tbxBrand";
            this.tbxBrand.Size = new System.Drawing.Size(121, 20);
            this.tbxBrand.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Märke";
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(69, 142);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(121, 20);
            this.tbxModel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Modell";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Typ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Register";
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Bil",
            "MC"});
            this.cbxType.Location = new System.Drawing.Point(69, 168);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 21);
            this.cbxType.TabIndex = 9;
            // 
            // lbxOutput
            // 
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.Location = new System.Drawing.Point(219, 55);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(213, 134);
            this.lbxOutput.TabIndex = 10;
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(69, 214);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(121, 23);
            this.btnRegistration.TabIndex = 11;
            this.btnRegistration.Text = "Registrera";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.BtnRegistration_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnMC);
            this.groupBox1.Controls.Add(this.rbnCar);
            this.groupBox1.Controls.Add(this.rbnAll);
            this.groupBox1.Location = new System.Drawing.Point(219, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 59);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visa";
            // 
            // rbnMC
            // 
            this.rbnMC.AutoSize = true;
            this.rbnMC.Location = new System.Drawing.Point(105, 19);
            this.rbnMC.Name = "rbnMC";
            this.rbnMC.Size = new System.Drawing.Size(41, 17);
            this.rbnMC.TabIndex = 2;
            this.rbnMC.TabStop = true;
            this.rbnMC.Text = "MC";
            this.rbnMC.UseVisualStyleBackColor = true;
            this.rbnMC.CheckedChanged += new System.EventHandler(this.RbnMC_CheckedChanged);
            // 
            // rbnCar
            // 
            this.rbnCar.AutoSize = true;
            this.rbnCar.Location = new System.Drawing.Point(54, 19);
            this.rbnCar.Name = "rbnCar";
            this.rbnCar.Size = new System.Drawing.Size(45, 17);
            this.rbnCar.TabIndex = 1;
            this.rbnCar.TabStop = true;
            this.rbnCar.Text = "Bilar";
            this.rbnCar.UseVisualStyleBackColor = true;
            this.rbnCar.CheckedChanged += new System.EventHandler(this.RbnCar_CheckedChanged);
            // 
            // rbnAll
            // 
            this.rbnAll.AutoSize = true;
            this.rbnAll.Location = new System.Drawing.Point(6, 19);
            this.rbnAll.Name = "rbnAll";
            this.rbnAll.Size = new System.Drawing.Size(42, 17);
            this.rbnAll.TabIndex = 0;
            this.rbnAll.TabStop = true;
            this.rbnAll.Text = "Alla";
            this.rbnAll.UseVisualStyleBackColor = true;
            this.rbnAll.CheckedChanged += new System.EventHandler(this.RbnAll_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 264);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.lbxOutput);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxBrand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxRegnr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxRegnr;
        private System.Windows.Forms.TextBox tbxBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.ListBox lbxOutput;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnMC;
        private System.Windows.Forms.RadioButton rbnCar;
        private System.Windows.Forms.RadioButton rbnAll;
    }
}

