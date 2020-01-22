namespace UDPserver
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
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxMessages = new System.Windows.Forms.TextBox();
            this.btnRecive = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serverns portnummer";
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(128, 19);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(100, 20);
            this.tbxPort.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRecive);
            this.groupBox1.Controls.Add(this.tbxMessages);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 210);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inkorg";
            // 
            // tbxMessages
            // 
            this.tbxMessages.Location = new System.Drawing.Point(6, 19);
            this.tbxMessages.Multiline = true;
            this.tbxMessages.Name = "tbxMessages";
            this.tbxMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxMessages.Size = new System.Drawing.Size(322, 153);
            this.tbxMessages.TabIndex = 0;
            // 
            // btnRecive
            // 
            this.btnRecive.Location = new System.Drawing.Point(6, 178);
            this.btnRecive.Name = "btnRecive";
            this.btnRecive.Size = new System.Drawing.Size(322, 23);
            this.btnRecive.TabIndex = 1;
            this.btnRecive.Text = "Ta emot";
            this.btnRecive.UseVisualStyleBackColor = true;
            this.btnRecive.Click += new System.EventHandler(this.btnRecive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 277);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "UDP Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRecive;
        private System.Windows.Forms.TextBox tbxMessages;
    }
}

