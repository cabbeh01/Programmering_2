namespace TCP
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
            this.btnSendHey = new System.Windows.Forms.Button();
            this.tbxIP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serverns IP-address";
            // 
            // btnSendHey
            // 
            this.btnSendHey.Location = new System.Drawing.Point(96, 91);
            this.btnSendHey.Name = "btnSendHey";
            this.btnSendHey.Size = new System.Drawing.Size(75, 23);
            this.btnSendHey.TabIndex = 1;
            this.btnSendHey.Text = "Säg Hej";
            this.btnSendHey.UseVisualStyleBackColor = true;
            this.btnSendHey.Click += new System.EventHandler(this.btnSendHey_Click);
            // 
            // tbxIP
            // 
            this.tbxIP.Location = new System.Drawing.Point(60, 65);
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(148, 20);
            this.tbxIP.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 179);
            this.Controls.Add(this.tbxIP);
            this.Controls.Add(this.btnSendHey);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendHey;
        private System.Windows.Forms.TextBox tbxIP;
    }
}

