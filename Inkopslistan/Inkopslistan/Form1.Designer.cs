namespace Inkopslistan
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbxVara = new System.Windows.Forms.TextBox();
            this.tbxMangd = new System.Windows.Forms.TextBox();
            this.tbxPris = new System.Windows.Forms.TextBox();
            this.gbxVarutyp = new System.Windows.Forms.GroupBox();
            this.rbtnStycksak = new System.Windows.Forms.RadioButton();
            this.rbtnLosvikt = new System.Windows.Forms.RadioButton();
            this.lbxOut = new System.Windows.Forms.ListBox();
            this.btnLaggtill = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxSumma = new System.Windows.Forms.TextBox();
            this.btnRadera = new System.Windows.Forms.Button();
            this.gbxVarutyp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pris";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mängd";
            // 
            // tbxVara
            // 
            this.tbxVara.Location = new System.Drawing.Point(74, 12);
            this.tbxVara.Name = "tbxVara";
            this.tbxVara.Size = new System.Drawing.Size(130, 20);
            this.tbxVara.TabIndex = 3;
            // 
            // tbxMangd
            // 
            this.tbxMangd.Location = new System.Drawing.Point(74, 77);
            this.tbxMangd.Name = "tbxMangd";
            this.tbxMangd.Size = new System.Drawing.Size(130, 20);
            this.tbxMangd.TabIndex = 4;
            // 
            // tbxPris
            // 
            this.tbxPris.Location = new System.Drawing.Point(74, 44);
            this.tbxPris.Name = "tbxPris";
            this.tbxPris.Size = new System.Drawing.Size(130, 20);
            this.tbxPris.TabIndex = 4;
            // 
            // gbxVarutyp
            // 
            this.gbxVarutyp.Controls.Add(this.rbtnStycksak);
            this.gbxVarutyp.Controls.Add(this.rbtnLosvikt);
            this.gbxVarutyp.Location = new System.Drawing.Point(74, 112);
            this.gbxVarutyp.Name = "gbxVarutyp";
            this.gbxVarutyp.Size = new System.Drawing.Size(130, 83);
            this.gbxVarutyp.TabIndex = 5;
            this.gbxVarutyp.TabStop = false;
            this.gbxVarutyp.Text = "Varutyp";
            // 
            // rbtnStycksak
            // 
            this.rbtnStycksak.AutoSize = true;
            this.rbtnStycksak.Location = new System.Drawing.Point(9, 48);
            this.rbtnStycksak.Name = "rbtnStycksak";
            this.rbtnStycksak.Size = new System.Drawing.Size(69, 17);
            this.rbtnStycksak.TabIndex = 1;
            this.rbtnStycksak.Text = "Stycksak";
            this.rbtnStycksak.UseVisualStyleBackColor = true;
            // 
            // rbtnLosvikt
            // 
            this.rbtnLosvikt.AutoSize = true;
            this.rbtnLosvikt.Checked = true;
            this.rbtnLosvikt.Location = new System.Drawing.Point(9, 25);
            this.rbtnLosvikt.Name = "rbtnLosvikt";
            this.rbtnLosvikt.Size = new System.Drawing.Size(59, 17);
            this.rbtnLosvikt.TabIndex = 0;
            this.rbtnLosvikt.TabStop = true;
            this.rbtnLosvikt.Text = "Lösvikt";
            this.rbtnLosvikt.UseVisualStyleBackColor = true;
            // 
            // lbxOut
            // 
            this.lbxOut.FormattingEnabled = true;
            this.lbxOut.Location = new System.Drawing.Point(220, 12);
            this.lbxOut.Name = "lbxOut";
            this.lbxOut.Size = new System.Drawing.Size(216, 394);
            this.lbxOut.TabIndex = 6;
            this.lbxOut.SelectedIndexChanged += new System.EventHandler(this.LbxOut_SelectedIndexChanged);
            // 
            // btnLaggtill
            // 
            this.btnLaggtill.Location = new System.Drawing.Point(12, 415);
            this.btnLaggtill.Name = "btnLaggtill";
            this.btnLaggtill.Size = new System.Drawing.Size(75, 23);
            this.btnLaggtill.TabIndex = 7;
            this.btnLaggtill.Text = "Lägg till";
            this.btnLaggtill.UseVisualStyleBackColor = true;
            this.btnLaggtill.Click += new System.EventHandler(this.BtnLaggtill_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Summa (kr)";
            // 
            // tbxSumma
            // 
            this.tbxSumma.Location = new System.Drawing.Point(285, 412);
            this.tbxSumma.Name = "tbxSumma";
            this.tbxSumma.Size = new System.Drawing.Size(151, 20);
            this.tbxSumma.TabIndex = 9;
            // 
            // btnRadera
            // 
            this.btnRadera.Enabled = false;
            this.btnRadera.Location = new System.Drawing.Point(93, 415);
            this.btnRadera.Name = "btnRadera";
            this.btnRadera.Size = new System.Drawing.Size(75, 23);
            this.btnRadera.TabIndex = 10;
            this.btnRadera.Text = "Ta bort";
            this.btnRadera.UseVisualStyleBackColor = true;
            this.btnRadera.Click += new System.EventHandler(this.BtnRadera_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.btnRadera);
            this.Controls.Add(this.tbxSumma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLaggtill);
            this.Controls.Add(this.lbxOut);
            this.Controls.Add(this.gbxVarutyp);
            this.Controls.Add(this.tbxPris);
            this.Controls.Add(this.tbxMangd);
            this.Controls.Add(this.tbxVara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxVarutyp.ResumeLayout(false);
            this.gbxVarutyp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxVara;
        private System.Windows.Forms.TextBox tbxMangd;
        private System.Windows.Forms.TextBox tbxPris;
        private System.Windows.Forms.GroupBox gbxVarutyp;
        private System.Windows.Forms.RadioButton rbtnStycksak;
        private System.Windows.Forms.RadioButton rbtnLosvikt;
        private System.Windows.Forms.ListBox lbxOut;
        private System.Windows.Forms.Button btnLaggtill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxSumma;
        private System.Windows.Forms.Button btnRadera;
    }
}

