namespace _1_3
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
            this.rtbx = new System.Windows.Forms.RichTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxBold = new System.Windows.Forms.CheckBox();
            this.cbxItalic = new System.Windows.Forms.CheckBox();
            this.cbxUnderline = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cDialog = new System.Windows.Forms.ColorDialog();
            this.pbxColor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbx
            // 
            this.rtbx.Location = new System.Drawing.Point(12, 12);
            this.rtbx.Name = "rtbx";
            this.rtbx.Size = new System.Drawing.Size(301, 173);
            this.rtbx.TabIndex = 0;
            this.rtbx.Text = "När alla vännerna gått hem\noch dörren har stängts igen\noch mörkret\ndet skrämmer i" +
    "gen\nNär alla vännerna gått hem\n";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(238, 262);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Updatera";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // cbxBold
            // 
            this.cbxBold.AutoSize = true;
            this.cbxBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBold.Location = new System.Drawing.Point(12, 220);
            this.cbxBold.Name = "cbxBold";
            this.cbxBold.Size = new System.Drawing.Size(44, 17);
            this.cbxBold.TabIndex = 2;
            this.cbxBold.Text = "Fet";
            this.cbxBold.UseVisualStyleBackColor = true;
            // 
            // cbxItalic
            // 
            this.cbxItalic.AutoSize = true;
            this.cbxItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItalic.Location = new System.Drawing.Point(12, 243);
            this.cbxItalic.Name = "cbxItalic";
            this.cbxItalic.Size = new System.Drawing.Size(55, 17);
            this.cbxItalic.TabIndex = 3;
            this.cbxItalic.Text = "Kursiv";
            this.cbxItalic.UseVisualStyleBackColor = true;
            // 
            // cbxUnderline
            // 
            this.cbxUnderline.AutoSize = true;
            this.cbxUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUnderline.Location = new System.Drawing.Point(12, 266);
            this.cbxUnderline.Name = "cbxUnderline";
            this.cbxUnderline.Size = new System.Drawing.Size(84, 17);
            this.cbxUnderline.TabIndex = 4;
            this.cbxUnderline.Text = "Understräck";
            this.cbxUnderline.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(193, 220);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 30);
            this.listBox1.TabIndex = 5;
            // 
            // nUpDown
            // 
            this.nUpDown.Location = new System.Drawing.Point(113, 220);
            this.nUpDown.Name = "nUpDown";
            this.nUpDown.Size = new System.Drawing.Size(47, 20);
            this.nUpDown.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Typsnitt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Storlek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Färg";
            // 
            // pbxColor
            // 
            this.pbxColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbxColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxColor.Location = new System.Drawing.Point(113, 263);
            this.pbxColor.Name = "pbxColor";
            this.pbxColor.Size = new System.Drawing.Size(47, 22);
            this.pbxColor.TabIndex = 10;
            this.pbxColor.TabStop = false;
            this.pbxColor.Click += new System.EventHandler(this.PbxColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 302);
            this.Controls.Add(this.pbxColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nUpDown);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cbxUnderline);
            this.Controls.Add(this.cbxItalic);
            this.Controls.Add(this.cbxBold);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.rtbx);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbx;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox cbxBold;
        private System.Windows.Forms.CheckBox cbxItalic;
        private System.Windows.Forms.CheckBox cbxUnderline;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown nUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog cDialog;
        private System.Windows.Forms.PictureBox pbxColor;
    }
}

