namespace Styrketraning
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxOvning = new System.Windows.Forms.TextBox();
            this.tbxSet = new System.Windows.Forms.TextBox();
            this.tbxRep = new System.Windows.Forms.TextBox();
            this.tbxVikt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSpara = new System.Windows.Forms.Button();
            this.btnSok = new System.Windows.Forms.Button();
            this.tbxOvningSok = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxShow = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSpara);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxVikt);
            this.groupBox1.Controls.Add(this.tbxRep);
            this.groupBox1.Controls.Add(this.tbxSet);
            this.groupBox1.Controls.Add(this.tbxOvning);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lägg in övning";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxShow);
            this.groupBox2.Controls.Add(this.tbxOvningSok);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnSok);
            this.groupBox2.Location = new System.Drawing.Point(249, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 166);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sök på övning";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Övning:";
            // 
            // tbxOvning
            // 
            this.tbxOvning.Location = new System.Drawing.Point(33, 50);
            this.tbxOvning.Name = "tbxOvning";
            this.tbxOvning.Size = new System.Drawing.Size(100, 20);
            this.tbxOvning.TabIndex = 1;
            // 
            // tbxSet
            // 
            this.tbxSet.Location = new System.Drawing.Point(33, 76);
            this.tbxSet.Name = "tbxSet";
            this.tbxSet.Size = new System.Drawing.Size(46, 20);
            this.tbxSet.TabIndex = 2;
            // 
            // tbxRep
            // 
            this.tbxRep.Location = new System.Drawing.Point(85, 76);
            this.tbxRep.Name = "tbxRep";
            this.tbxRep.Size = new System.Drawing.Size(46, 20);
            this.tbxRep.TabIndex = 3;
            // 
            // tbxVikt
            // 
            this.tbxVikt.Location = new System.Drawing.Point(137, 76);
            this.tbxVikt.Name = "tbxVikt";
            this.tbxVikt.Size = new System.Drawing.Size(46, 20);
            this.tbxVikt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Set";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rep";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vikt";
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(33, 124);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(98, 23);
            this.btnSpara.TabIndex = 8;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.BtnSpara_Click);
            // 
            // btnSok
            // 
            this.btnSok.Location = new System.Drawing.Point(20, 74);
            this.btnSok.Name = "btnSok";
            this.btnSok.Size = new System.Drawing.Size(114, 23);
            this.btnSok.TabIndex = 9;
            this.btnSok.Text = "Total vikt ->";
            this.btnSok.UseVisualStyleBackColor = true;
            this.btnSok.Click += new System.EventHandler(this.BtnSok_Click);
            // 
            // tbxOvningSok
            // 
            this.tbxOvningSok.Location = new System.Drawing.Point(20, 50);
            this.tbxOvningSok.Name = "tbxOvningSok";
            this.tbxOvningSok.Size = new System.Drawing.Size(180, 20);
            this.tbxOvningSok.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Övning:";
            // 
            // tbxShow
            // 
            this.tbxShow.Location = new System.Drawing.Point(140, 77);
            this.tbxShow.Name = "tbxShow";
            this.tbxShow.ReadOnly = true;
            this.tbxShow.Size = new System.Drawing.Size(60, 20);
            this.tbxShow.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 195);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxVikt;
        private System.Windows.Forms.TextBox tbxRep;
        private System.Windows.Forms.TextBox tbxSet;
        private System.Windows.Forms.TextBox tbxOvning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxShow;
        private System.Windows.Forms.TextBox tbxOvningSok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSok;
    }
}

