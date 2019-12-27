namespace AlphaWord
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
            this.rtbxText = new System.Windows.Forms.RichTextBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnAlignleft = new System.Windows.Forms.Button();
            this.btnAlignmiddle = new System.Windows.Forms.Button();
            this.btnAlignRight = new System.Windows.Forms.Button();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.pbxColor = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dlgPrint = new System.Windows.Forms.PrintDialog();
            this.dlgPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbxText
            // 
            this.rtbxText.Location = new System.Drawing.Point(12, 51);
            this.rtbxText.Name = "rtbxText";
            this.rtbxText.Size = new System.Drawing.Size(776, 387);
            this.rtbxText.TabIndex = 0;
            this.rtbxText.Text = "";
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(12, 12);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(75, 23);
            this.btnFont.TabIndex = 1;
            this.btnFont.Text = "Typsnitt";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnAlignleft
            // 
            this.btnAlignleft.Location = new System.Drawing.Point(112, 12);
            this.btnAlignleft.Name = "btnAlignleft";
            this.btnAlignleft.Size = new System.Drawing.Size(36, 23);
            this.btnAlignleft.TabIndex = 2;
            this.btnAlignleft.Text = "L";
            this.btnAlignleft.UseVisualStyleBackColor = true;
            this.btnAlignleft.Click += new System.EventHandler(this.btnAlignleft_Click);
            // 
            // btnAlignmiddle
            // 
            this.btnAlignmiddle.Location = new System.Drawing.Point(154, 12);
            this.btnAlignmiddle.Name = "btnAlignmiddle";
            this.btnAlignmiddle.Size = new System.Drawing.Size(36, 23);
            this.btnAlignmiddle.TabIndex = 3;
            this.btnAlignmiddle.Text = "C";
            this.btnAlignmiddle.UseVisualStyleBackColor = true;
            this.btnAlignmiddle.Click += new System.EventHandler(this.btnAlignmiddle_Click);
            // 
            // btnAlignRight
            // 
            this.btnAlignRight.Location = new System.Drawing.Point(196, 12);
            this.btnAlignRight.Name = "btnAlignRight";
            this.btnAlignRight.Size = new System.Drawing.Size(36, 23);
            this.btnAlignRight.TabIndex = 4;
            this.btnAlignRight.Text = "R";
            this.btnAlignRight.UseVisualStyleBackColor = true;
            this.btnAlignRight.Click += new System.EventHandler(this.btnAlignRight_Click);
            // 
            // pbxColor
            // 
            this.pbxColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbxColor.Location = new System.Drawing.Point(248, 12);
            this.pbxColor.Name = "pbxColor";
            this.pbxColor.Size = new System.Drawing.Size(30, 22);
            this.pbxColor.TabIndex = 5;
            this.pbxColor.TabStop = false;
            this.pbxColor.Click += new System.EventHandler(this.PbxColor_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(709, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(79, 23);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Skriv ut";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // dlgPrint
            // 
            this.dlgPrint.UseEXDialog = true;
            // 
            // dlgPrintDocument
            // 
            this.dlgPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.DlgPrintDocument_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pbxColor);
            this.Controls.Add(this.btnAlignRight);
            this.Controls.Add(this.btnAlignmiddle);
            this.Controls.Add(this.btnAlignleft);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.rtbxText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxText;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnAlignleft;
        private System.Windows.Forms.Button btnAlignmiddle;
        private System.Windows.Forms.Button btnAlignRight;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.PictureBox pbxColor;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintDialog dlgPrint;
        private System.Drawing.Printing.PrintDocument dlgPrintDocument;
        private System.Windows.Forms.FontDialog dlgFont;
    }
}

