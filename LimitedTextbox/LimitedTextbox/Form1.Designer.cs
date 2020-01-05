namespace LimitedTextbox
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
            this.limitedTBX1 = new LimitedTextbox.LimitedTBX();
            this.limitedTBX2 = new LimitedTextbox.LimitedTBX();
            this.SuspendLayout();
            // 
            // limitedTBX1
            // 
            this.limitedTBX1.Location = new System.Drawing.Point(12, 12);
            this.limitedTBX1.Name = "limitedTBX1";
            this.limitedTBX1.Size = new System.Drawing.Size(280, 138);
            this.limitedTBX1.TabIndex = 0;
            // 
            // limitedTBX2
            // 
            this.limitedTBX2.Location = new System.Drawing.Point(12, 156);
            this.limitedTBX2.Name = "limitedTBX2";
            this.limitedTBX2.Size = new System.Drawing.Size(280, 138);
            this.limitedTBX2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.limitedTBX2);
            this.Controls.Add(this.limitedTBX1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private LimitedTBX limitedTBX1;
        private LimitedTBX limitedTBX2;
    }
}

