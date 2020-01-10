namespace LabeledTbx
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
            this.labeledTextbox1 = new LabeledTbx.LabeledTextbox();
            this.labeledTextbox2 = new LabeledTbx.LabeledTextbox();
            this.labeledTextbox3 = new LabeledTbx.LabeledTextbox();
            this.SuspendLayout();
            // 
            // labeledTextbox1
            // 
            this.labeledTextbox1.ForeColor = System.Drawing.Color.Gray;
            this.labeledTextbox1.LedText = "Förnamn";
            this.labeledTextbox1.Location = new System.Drawing.Point(28, 25);
            this.labeledTextbox1.Name = "labeledTextbox1";
            this.labeledTextbox1.Size = new System.Drawing.Size(215, 20);
            this.labeledTextbox1.TabIndex = 0;
            this.labeledTextbox1.Text = "Förnamn";
            // 
            // labeledTextbox2
            // 
            this.labeledTextbox2.ForeColor = System.Drawing.Color.Gray;
            this.labeledTextbox2.LedText = "Efternamn";
            this.labeledTextbox2.Location = new System.Drawing.Point(28, 51);
            this.labeledTextbox2.Name = "labeledTextbox2";
            this.labeledTextbox2.Size = new System.Drawing.Size(215, 20);
            this.labeledTextbox2.TabIndex = 1;
            this.labeledTextbox2.Text = "Efternamn";
            // 
            // labeledTextbox3
            // 
            this.labeledTextbox3.ForeColor = System.Drawing.Color.Gray;
            this.labeledTextbox3.LedText = "Titel";
            this.labeledTextbox3.Location = new System.Drawing.Point(28, 77);
            this.labeledTextbox3.Name = "labeledTextbox3";
            this.labeledTextbox3.Size = new System.Drawing.Size(215, 20);
            this.labeledTextbox3.TabIndex = 2;
            this.labeledTextbox3.Text = "Titel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 138);
            this.Controls.Add(this.labeledTextbox3);
            this.Controls.Add(this.labeledTextbox2);
            this.Controls.Add(this.labeledTextbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabeledTextbox labeledTextbox1;
        private LabeledTextbox labeledTextbox2;
        private LabeledTextbox labeledTextbox3;
    }
}

