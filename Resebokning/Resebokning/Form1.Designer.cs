namespace Resebokning
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBoka = new System.Windows.Forms.Button();
            this.gbxSokKund = new System.Windows.Forms.GroupBox();
            this.tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSok = new System.Windows.Forms.Button();
            this.lbxSokt = new System.Windows.Forms.ListBox();
            this.gbxSokKund.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kund";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(91, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Antal Dagar";
            // 
            // btnBoka
            // 
            this.btnBoka.Location = new System.Drawing.Point(197, 99);
            this.btnBoka.Name = "btnBoka";
            this.btnBoka.Size = new System.Drawing.Size(43, 23);
            this.btnBoka.TabIndex = 6;
            this.btnBoka.Text = "Boka";
            this.btnBoka.UseVisualStyleBackColor = true;
            // 
            // gbxSokKund
            // 
            this.gbxSokKund.Controls.Add(this.lbxSokt);
            this.gbxSokKund.Controls.Add(this.btnSok);
            this.gbxSokKund.Controls.Add(this.tbx);
            this.gbxSokKund.Controls.Add(this.label4);
            this.gbxSokKund.Location = new System.Drawing.Point(27, 149);
            this.gbxSokKund.Name = "gbxSokKund";
            this.gbxSokKund.Size = new System.Drawing.Size(241, 195);
            this.gbxSokKund.TabIndex = 7;
            this.gbxSokKund.TabStop = false;
            this.gbxSokKund.Text = "Sök kund";
            // 
            // tbx
            // 
            this.tbx.Location = new System.Drawing.Point(64, 19);
            this.tbx.Name = "tbx";
            this.tbx.Size = new System.Drawing.Size(100, 20);
            this.tbx.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // btnSok
            // 
            this.btnSok.Location = new System.Drawing.Point(170, 17);
            this.btnSok.Name = "btnSok";
            this.btnSok.Size = new System.Drawing.Size(43, 23);
            this.btnSok.TabIndex = 8;
            this.btnSok.Text = "Sök";
            this.btnSok.UseVisualStyleBackColor = true;
            // 
            // lbxSokt
            // 
            this.lbxSokt.FormattingEnabled = true;
            this.lbxSokt.Location = new System.Drawing.Point(26, 56);
            this.lbxSokt.Name = "lbxSokt";
            this.lbxSokt.Size = new System.Drawing.Size(172, 121);
            this.lbxSokt.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 361);
            this.Controls.Add(this.gbxSokKund);
            this.Controls.Add(this.btnBoka);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxSokKund.ResumeLayout(false);
            this.gbxSokKund.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBoka;
        private System.Windows.Forms.GroupBox gbxSokKund;
        private System.Windows.Forms.ListBox lbxSokt;
        private System.Windows.Forms.Button btnSok;
        private System.Windows.Forms.TextBox tbx;
        private System.Windows.Forms.Label label4;
    }
}

