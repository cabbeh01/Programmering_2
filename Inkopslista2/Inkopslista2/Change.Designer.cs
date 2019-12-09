namespace Inkopslista2
{
    partial class Change
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
            this.tbxNameCH = new System.Windows.Forms.TextBox();
            this.tbxPrisCH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMangdCH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbtnLosviktCH = new System.Windows.Forms.RadioButton();
            this.rbtnStycksakCH = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn";
            // 
            // tbxNameCH
            // 
            this.tbxNameCH.Location = new System.Drawing.Point(83, 45);
            this.tbxNameCH.Name = "tbxNameCH";
            this.tbxNameCH.Size = new System.Drawing.Size(100, 20);
            this.tbxNameCH.TabIndex = 1;
            // 
            // tbxPrisCH
            // 
            this.tbxPrisCH.Location = new System.Drawing.Point(83, 71);
            this.tbxPrisCH.Name = "tbxPrisCH";
            this.tbxPrisCH.Size = new System.Drawing.Size(100, 20);
            this.tbxPrisCH.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pris";
            // 
            // tbxMangdCH
            // 
            this.tbxMangdCH.Location = new System.Drawing.Point(83, 97);
            this.tbxMangdCH.Name = "tbxMangdCH";
            this.tbxMangdCH.Size = new System.Drawing.Size(100, 20);
            this.tbxMangdCH.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mangd";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnStycksakCH);
            this.groupBox1.Controls.Add(this.rbtnLosviktCH);
            this.groupBox1.Location = new System.Drawing.Point(189, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 72);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Varutyp";
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(83, 161);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 7;
            this.btnCancle.Text = "Avbryt";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(189, 161);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Spara";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbtnLosviktCH
            // 
            this.rbtnLosviktCH.AutoSize = true;
            this.rbtnLosviktCH.Checked = true;
            this.rbtnLosviktCH.Location = new System.Drawing.Point(7, 20);
            this.rbtnLosviktCH.Name = "rbtnLosviktCH";
            this.rbtnLosviktCH.Size = new System.Drawing.Size(59, 17);
            this.rbtnLosviktCH.TabIndex = 0;
            this.rbtnLosviktCH.TabStop = true;
            this.rbtnLosviktCH.Text = "Lösvikt";
            this.rbtnLosviktCH.UseVisualStyleBackColor = true;
            // 
            // rbtnStycksakCH
            // 
            this.rbtnStycksakCH.AutoSize = true;
            this.rbtnStycksakCH.Location = new System.Drawing.Point(7, 43);
            this.rbtnStycksakCH.Name = "rbtnStycksakCH";
            this.rbtnStycksakCH.Size = new System.Drawing.Size(69, 17);
            this.rbtnStycksakCH.TabIndex = 1;
            this.rbtnStycksakCH.TabStop = true;
            this.rbtnStycksakCH.Text = "Stycksak";
            this.rbtnStycksakCH.UseVisualStyleBackColor = true;
            // 
            // Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 227);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxMangdCH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxPrisCH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxNameCH);
            this.Controls.Add(this.label1);
            this.Name = "Change";
            this.Text = "Ändra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNameCH;
        private System.Windows.Forms.TextBox tbxPrisCH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMangdCH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbtnStycksakCH;
        private System.Windows.Forms.RadioButton rbtnLosviktCH;
    }
}