namespace Inkopslista2
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
            this.tbxVara = new System.Windows.Forms.TextBox();
            this.tbxPris = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMangd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnStycksaker = new System.Windows.Forms.RadioButton();
            this.rbtnLosvikt = new System.Windows.Forms.RadioButton();
            this.lbxOut = new System.Windows.Forms.ListBox();
            this.tbxRabatt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxSumma = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.gbxModify = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.gbxModify.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vara";
            // 
            // tbxVara
            // 
            this.tbxVara.Location = new System.Drawing.Point(60, 22);
            this.tbxVara.Name = "tbxVara";
            this.tbxVara.Size = new System.Drawing.Size(100, 20);
            this.tbxVara.TabIndex = 1;
            // 
            // tbxPris
            // 
            this.tbxPris.Location = new System.Drawing.Point(60, 48);
            this.tbxPris.Name = "tbxPris";
            this.tbxPris.Size = new System.Drawing.Size(100, 20);
            this.tbxPris.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pris";
            // 
            // tbxMangd
            // 
            this.tbxMangd.Location = new System.Drawing.Point(60, 74);
            this.tbxMangd.Name = "tbxMangd";
            this.tbxMangd.Size = new System.Drawing.Size(100, 20);
            this.tbxMangd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mängd";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnStycksaker);
            this.groupBox1.Controls.Add(this.rbtnLosvikt);
            this.groupBox1.Location = new System.Drawing.Point(60, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Varutyp";
            // 
            // rbtnStycksaker
            // 
            this.rbtnStycksaker.AutoSize = true;
            this.rbtnStycksaker.Location = new System.Drawing.Point(9, 54);
            this.rbtnStycksaker.Name = "rbtnStycksaker";
            this.rbtnStycksaker.Size = new System.Drawing.Size(78, 17);
            this.rbtnStycksaker.TabIndex = 1;
            this.rbtnStycksaker.Text = "Stycksaker";
            this.rbtnStycksaker.UseVisualStyleBackColor = true;
            // 
            // rbtnLosvikt
            // 
            this.rbtnLosvikt.AutoSize = true;
            this.rbtnLosvikt.Checked = true;
            this.rbtnLosvikt.Location = new System.Drawing.Point(9, 31);
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
            this.lbxOut.Location = new System.Drawing.Point(166, 22);
            this.lbxOut.Name = "lbxOut";
            this.lbxOut.Size = new System.Drawing.Size(188, 173);
            this.lbxOut.TabIndex = 7;
            this.lbxOut.SelectedIndexChanged += new System.EventHandler(this.LbxOut_SelectedIndexChanged);
            // 
            // tbxRabatt
            // 
            this.tbxRabatt.Location = new System.Drawing.Point(60, 219);
            this.tbxRabatt.Name = "tbxRabatt";
            this.tbxRabatt.Size = new System.Drawing.Size(100, 20);
            this.tbxRabatt.TabIndex = 8;
            this.tbxRabatt.TextChanged += new System.EventHandler(this.tbxRabatt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rabatt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Summa (kr)";
            // 
            // tbxSumma
            // 
            this.tbxSumma.Location = new System.Drawing.Point(254, 219);
            this.tbxSumma.Name = "tbxSumma";
            this.tbxSumma.Size = new System.Drawing.Size(100, 20);
            this.tbxSumma.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(22, 266);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Lägg till";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(6, 25);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Ta bort";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(6, 51);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 14;
            this.btnChange.Text = "Ändra";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // gbxModify
            // 
            this.gbxModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbxModify.Controls.Add(this.btnChange);
            this.gbxModify.Controls.Add(this.btnRemove);
            this.gbxModify.Enabled = false;
            this.gbxModify.Location = new System.Drawing.Point(360, 16);
            this.gbxModify.Name = "gbxModify";
            this.gbxModify.Size = new System.Drawing.Size(92, 100);
            this.gbxModify.TabIndex = 15;
            this.gbxModify.TabStop = false;
            this.gbxModify.Text = "Modifera";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 304);
            this.Controls.Add(this.gbxModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxSumma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxRabatt);
            this.Controls.Add(this.lbxOut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxMangd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxPris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxVara);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxModify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxVara;
        private System.Windows.Forms.TextBox tbxPris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMangd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnStycksaker;
        private System.Windows.Forms.RadioButton rbtnLosvikt;
        private System.Windows.Forms.ListBox lbxOut;
        private System.Windows.Forms.TextBox tbxRabatt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxSumma;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.GroupBox gbxModify;
    }
}

