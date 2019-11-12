namespace Clipart
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbxShow = new System.Windows.Forms.ListBox();
            this.tbxArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcTotalArea = new System.Windows.Forms.Button();
            this.btnCreateTriangle = new System.Windows.Forms.Button();
            this.btnCreateCircle = new System.Windows.Forms.Button();
            this.btnCreateLine = new System.Windows.Forms.Button();
            this.tbxHeight = new System.Windows.Forms.TextBox();
            this.tbxWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxWidth);
            this.groupBox1.Controls.Add(this.tbxHeight);
            this.groupBox1.Controls.Add(this.btnCreateLine);
            this.groupBox1.Controls.Add(this.btnCreateCircle);
            this.groupBox1.Controls.Add(this.btnCreateTriangle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skapa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Figurlista";
            // 
            // lbxShow
            // 
            this.lbxShow.FormattingEnabled = true;
            this.lbxShow.Location = new System.Drawing.Point(222, 29);
            this.lbxShow.Name = "lbxShow";
            this.lbxShow.Size = new System.Drawing.Size(120, 95);
            this.lbxShow.TabIndex = 2;
            // 
            // tbxArea
            // 
            this.tbxArea.Location = new System.Drawing.Point(222, 191);
            this.tbxArea.Name = "tbxArea";
            this.tbxArea.Size = new System.Drawing.Size(120, 20);
            this.tbxArea.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sammanlagd Area";
            // 
            // btnCalcTotalArea
            // 
            this.btnCalcTotalArea.Location = new System.Drawing.Point(12, 189);
            this.btnCalcTotalArea.Name = "btnCalcTotalArea";
            this.btnCalcTotalArea.Size = new System.Drawing.Size(163, 23);
            this.btnCalcTotalArea.TabIndex = 5;
            this.btnCalcTotalArea.Text = "Sammanlagd Area";
            this.btnCalcTotalArea.UseVisualStyleBackColor = true;
            this.btnCalcTotalArea.Click += new System.EventHandler(this.BtnCalcTotalArea_Click);
            // 
            // btnCreateTriangle
            // 
            this.btnCreateTriangle.Location = new System.Drawing.Point(61, 78);
            this.btnCreateTriangle.Name = "btnCreateTriangle";
            this.btnCreateTriangle.Size = new System.Drawing.Size(110, 23);
            this.btnCreateTriangle.TabIndex = 6;
            this.btnCreateTriangle.Text = "Skapa Triangel";
            this.btnCreateTriangle.UseVisualStyleBackColor = true;
            this.btnCreateTriangle.Click += new System.EventHandler(this.BtnCreateTriangle_Click);
            // 
            // btnCreateCircle
            // 
            this.btnCreateCircle.Location = new System.Drawing.Point(61, 107);
            this.btnCreateCircle.Name = "btnCreateCircle";
            this.btnCreateCircle.Size = new System.Drawing.Size(110, 23);
            this.btnCreateCircle.TabIndex = 7;
            this.btnCreateCircle.Text = "Skapa Cirkel";
            this.btnCreateCircle.UseVisualStyleBackColor = true;
            this.btnCreateCircle.Click += new System.EventHandler(this.BtnCreateCircle_Click);
            // 
            // btnCreateLine
            // 
            this.btnCreateLine.Location = new System.Drawing.Point(61, 136);
            this.btnCreateLine.Name = "btnCreateLine";
            this.btnCreateLine.Size = new System.Drawing.Size(110, 23);
            this.btnCreateLine.TabIndex = 8;
            this.btnCreateLine.Text = "Skapa Linje";
            this.btnCreateLine.UseVisualStyleBackColor = true;
            this.btnCreateLine.Click += new System.EventHandler(this.BtnCreateLine_Click);
            // 
            // tbxHeight
            // 
            this.tbxHeight.Location = new System.Drawing.Point(61, 52);
            this.tbxHeight.Name = "tbxHeight";
            this.tbxHeight.Size = new System.Drawing.Size(110, 20);
            this.tbxHeight.TabIndex = 6;
            // 
            // tbxWidth
            // 
            this.tbxWidth.Location = new System.Drawing.Point(61, 26);
            this.tbxWidth.Name = "tbxWidth";
            this.tbxWidth.Size = new System.Drawing.Size(110, 20);
            this.tbxWidth.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bredd:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Höjd:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 224);
            this.Controls.Add(this.btnCalcTotalArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxArea);
            this.Controls.Add(this.lbxShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxWidth;
        private System.Windows.Forms.TextBox tbxHeight;
        private System.Windows.Forms.Button btnCreateLine;
        private System.Windows.Forms.Button btnCreateCircle;
        private System.Windows.Forms.Button btnCreateTriangle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxShow;
        private System.Windows.Forms.TextBox tbxArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcTotalArea;
    }
}

