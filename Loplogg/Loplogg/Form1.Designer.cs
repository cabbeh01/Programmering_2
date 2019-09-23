namespace Loplogg
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
            this.tbxDistance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTime = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnShowTime = new System.Windows.Forms.Button();
            this.btnShowSpeed = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSearchDistance = new System.Windows.Forms.TextBox();
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxDistance
            // 
            this.tbxDistance.Location = new System.Drawing.Point(101, 35);
            this.tbxDistance.Name = "tbxDistance";
            this.tbxDistance.Size = new System.Drawing.Size(100, 20);
            this.tbxDistance.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sträcka (km)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tid (min)";
            // 
            // tbxTime
            // 
            this.tbxTime.Location = new System.Drawing.Point(101, 61);
            this.tbxTime.Name = "tbxTime";
            this.tbxTime.Size = new System.Drawing.Size(100, 20);
            this.tbxTime.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxOutput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnShowSpeed);
            this.groupBox1.Controls.Add(this.tbxSearchDistance);
            this.groupBox1.Controls.Add(this.btnShowTime);
            this.groupBox1.Location = new System.Drawing.Point(31, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 331);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sök på sträcka";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(215, 59);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Registrera";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // btnShowTime
            // 
            this.btnShowTime.Location = new System.Drawing.Point(85, 60);
            this.btnShowTime.Name = "btnShowTime";
            this.btnShowTime.Size = new System.Drawing.Size(119, 23);
            this.btnShowTime.TabIndex = 6;
            this.btnShowTime.Text = "Visa alla tider";
            this.btnShowTime.UseVisualStyleBackColor = true;
            this.btnShowTime.Click += new System.EventHandler(this.BtnShowTime_Click);
            // 
            // btnShowSpeed
            // 
            this.btnShowSpeed.Location = new System.Drawing.Point(85, 89);
            this.btnShowSpeed.Name = "btnShowSpeed";
            this.btnShowSpeed.Size = new System.Drawing.Size(119, 23);
            this.btnShowSpeed.TabIndex = 7;
            this.btnShowSpeed.Text = "Visa alla hastigheter";
            this.btnShowSpeed.UseVisualStyleBackColor = true;
            this.btnShowSpeed.Click += new System.EventHandler(this.BtnShowSpeed_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sträcka (km)";
            // 
            // tbxSearchDistance
            // 
            this.tbxSearchDistance.Location = new System.Drawing.Point(85, 34);
            this.tbxSearchDistance.Name = "tbxSearchDistance";
            this.tbxSearchDistance.Size = new System.Drawing.Size(119, 20);
            this.tbxSearchDistance.TabIndex = 6;
            // 
            // lbxOutput
            // 
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.Location = new System.Drawing.Point(6, 123);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(216, 199);
            this.lbxOutput.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 450);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxDistance);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxDistance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShowSpeed;
        private System.Windows.Forms.TextBox tbxSearchDistance;
        private System.Windows.Forms.Button btnShowTime;
        private System.Windows.Forms.Button btnRegister;
    }
}

