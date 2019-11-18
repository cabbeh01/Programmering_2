namespace DynamicList
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
            this.lbxShow = new System.Windows.Forms.ListBox();
            this.tbxSok = new System.Windows.Forms.TextBox();
            this.btnSok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxShow
            // 
            this.lbxShow.FormattingEnabled = true;
            this.lbxShow.Location = new System.Drawing.Point(12, 12);
            this.lbxShow.Name = "lbxShow";
            this.lbxShow.Size = new System.Drawing.Size(252, 251);
            this.lbxShow.TabIndex = 0;
            // 
            // tbxSok
            // 
            this.tbxSok.Location = new System.Drawing.Point(93, 284);
            this.tbxSok.Name = "tbxSok";
            this.tbxSok.Size = new System.Drawing.Size(100, 20);
            this.tbxSok.TabIndex = 1;
            // 
            // btnSok
            // 
            this.btnSok.Location = new System.Drawing.Point(12, 281);
            this.btnSok.Name = "btnSok";
            this.btnSok.Size = new System.Drawing.Size(75, 23);
            this.btnSok.TabIndex = 2;
            this.btnSok.Text = "Sök";
            this.btnSok.UseVisualStyleBackColor = true;
            this.btnSok.Click += new System.EventHandler(this.BtnSok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 450);
            this.Controls.Add(this.btnSok);
            this.Controls.Add(this.tbxSok);
            this.Controls.Add(this.lbxShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxShow;
        private System.Windows.Forms.TextBox tbxSok;
        private System.Windows.Forms.Button btnSok;
    }
}

