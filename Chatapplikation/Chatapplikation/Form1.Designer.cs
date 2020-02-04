namespace Chatapplikation
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
            this.tbxIP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbxOut = new System.Windows.Forms.TextBox();
            this.tbxChat = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serverns IP-adress";
            // 
            // tbxIP
            // 
            this.tbxIP.Location = new System.Drawing.Point(15, 51);
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(219, 20);
            this.tbxIP.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.tbxOut);
            this.groupBox1.Location = new System.Drawing.Point(12, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Utkorg";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(6, 45);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(288, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Skicka";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // tbxOut
            // 
            this.tbxOut.Location = new System.Drawing.Point(6, 19);
            this.tbxOut.Name = "tbxOut";
            this.tbxOut.Size = new System.Drawing.Size(288, 20);
            this.tbxOut.TabIndex = 6;
            // 
            // tbxChat
            // 
            this.tbxChat.Location = new System.Drawing.Point(12, 148);
            this.tbxChat.Multiline = true;
            this.tbxChat.Name = "tbxChat";
            this.tbxChat.Size = new System.Drawing.Size(297, 242);
            this.tbxChat.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(240, 51);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Anslut";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chatrum";
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(116, 77);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(118, 20);
            this.tbxPort.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Port";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(329, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 496);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbxChat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Klient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxIP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbxOut;
        private System.Windows.Forms.TextBox tbxChat;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    }
}

