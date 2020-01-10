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
            this.btnAlignleft = new System.Windows.Forms.Button();
            this.btnAlignmiddle = new System.Windows.Forms.Button();
            this.btnAlignRight = new System.Windows.Forms.Button();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.pbxColor = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dlgPrint = new System.Windows.Forms.PrintDialog();
            this.dlgPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.cbxFonts = new System.Windows.Forms.ComboBox();
            this.nUD = new System.Windows.Forms.NumericUpDown();
            this.btnFet = new System.Windows.Forms.Button();
            this.btnKursiv = new System.Windows.Forms.Button();
            this.btnUnder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbxText
            // 
            this.rtbxText.Location = new System.Drawing.Point(12, 51);
            this.rtbxText.Name = "rtbxText";
            this.rtbxText.Size = new System.Drawing.Size(776, 387);
            this.rtbxText.TabIndex = 0;
            this.rtbxText.Text = "";
            this.rtbxText.TextChanged += new System.EventHandler(this.rtbxText_TextChanged);
            // 
            // btnAlignleft
            // 
            this.btnAlignleft.Location = new System.Drawing.Point(330, 15);
            this.btnAlignleft.Name = "btnAlignleft";
            this.btnAlignleft.Size = new System.Drawing.Size(36, 23);
            this.btnAlignleft.TabIndex = 2;
            this.btnAlignleft.Text = "L";
            this.btnAlignleft.UseVisualStyleBackColor = true;
            this.btnAlignleft.Click += new System.EventHandler(this.btnAlignleft_Click);
            // 
            // btnAlignmiddle
            // 
            this.btnAlignmiddle.Location = new System.Drawing.Point(372, 15);
            this.btnAlignmiddle.Name = "btnAlignmiddle";
            this.btnAlignmiddle.Size = new System.Drawing.Size(36, 23);
            this.btnAlignmiddle.TabIndex = 3;
            this.btnAlignmiddle.Text = "C";
            this.btnAlignmiddle.UseVisualStyleBackColor = true;
            this.btnAlignmiddle.Click += new System.EventHandler(this.btnAlignmiddle_Click);
            // 
            // btnAlignRight
            // 
            this.btnAlignRight.Location = new System.Drawing.Point(414, 15);
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
            this.pbxColor.Location = new System.Drawing.Point(465, 16);
            this.pbxColor.Name = "pbxColor";
            this.pbxColor.Size = new System.Drawing.Size(30, 22);
            this.pbxColor.TabIndex = 5;
            this.pbxColor.TabStop = false;
            this.pbxColor.Click += new System.EventHandler(this.PbxColor_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(709, 15);
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
            // cbxFonts
            // 
            this.cbxFonts.FormattingEnabled = true;
            this.cbxFonts.Location = new System.Drawing.Point(12, 15);
            this.cbxFonts.Name = "cbxFonts";
            this.cbxFonts.Size = new System.Drawing.Size(121, 21);
            this.cbxFonts.TabIndex = 7;
            this.cbxFonts.SelectedIndexChanged += new System.EventHandler(this.cbxFonts_SelectedIndexChanged);
            // 
            // nUD
            // 
            this.nUD.Location = new System.Drawing.Point(140, 15);
            this.nUD.Name = "nUD";
            this.nUD.Size = new System.Drawing.Size(41, 20);
            this.nUD.TabIndex = 8;
            this.nUD.ValueChanged += new System.EventHandler(this.nUD_ValueChanged);
            // 
            // btnFet
            // 
            this.btnFet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFet.Location = new System.Drawing.Point(187, 15);
            this.btnFet.Name = "btnFet";
            this.btnFet.Size = new System.Drawing.Size(31, 23);
            this.btnFet.TabIndex = 9;
            this.btnFet.Text = "F";
            this.btnFet.UseVisualStyleBackColor = true;
            this.btnFet.Click += new System.EventHandler(this.btnFet_Click);
            // 
            // btnKursiv
            // 
            this.btnKursiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKursiv.Location = new System.Drawing.Point(224, 15);
            this.btnKursiv.Name = "btnKursiv";
            this.btnKursiv.Size = new System.Drawing.Size(31, 23);
            this.btnKursiv.TabIndex = 10;
            this.btnKursiv.Text = "K";
            this.btnKursiv.UseVisualStyleBackColor = true;
            this.btnKursiv.Click += new System.EventHandler(this.btnKursiv_Click);
            // 
            // btnUnder
            // 
            this.btnUnder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnder.Location = new System.Drawing.Point(261, 15);
            this.btnUnder.Name = "btnUnder";
            this.btnUnder.Size = new System.Drawing.Size(31, 23);
            this.btnUnder.TabIndex = 11;
            this.btnUnder.Text = "U";
            this.btnUnder.UseVisualStyleBackColor = true;
            this.btnUnder.Click += new System.EventHandler(this.btnUnder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUnder);
            this.Controls.Add(this.btnKursiv);
            this.Controls.Add(this.btnFet);
            this.Controls.Add(this.nUD);
            this.Controls.Add(this.cbxFonts);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pbxColor);
            this.Controls.Add(this.btnAlignRight);
            this.Controls.Add(this.btnAlignmiddle);
            this.Controls.Add(this.btnAlignleft);
            this.Controls.Add(this.rtbxText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxText;
        private System.Windows.Forms.Button btnAlignleft;
        private System.Windows.Forms.Button btnAlignmiddle;
        private System.Windows.Forms.Button btnAlignRight;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.PictureBox pbxColor;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintDialog dlgPrint;
        private System.Drawing.Printing.PrintDocument dlgPrintDocument;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.ComboBox cbxFonts;
        private System.Windows.Forms.NumericUpDown nUD;
        private System.Windows.Forms.Button btnFet;
        private System.Windows.Forms.Button btnKursiv;
        private System.Windows.Forms.Button btnUnder;
    }
}

