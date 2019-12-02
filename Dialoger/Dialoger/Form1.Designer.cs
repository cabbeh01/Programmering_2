namespace Dialoger
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
            this.btnColor = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.dlgFolderbrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.redigeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.väljFärgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.väljMappToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.väljTeckensnittToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(31, 24);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(121, 23);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "Välj en färg";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(31, 53);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(121, 23);
            this.btnFolder.TabIndex = 1;
            this.btnFolder.Text = "Öppna Mappväljaren";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.BtnFolder_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(31, 82);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(121, 23);
            this.btnFont.TabIndex = 2;
            this.btnFont.Text = "Välj teckensnitt";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.BtnFont_Click);
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redigeraToolStripMenuItem});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(182, 24);
            this.mnuStrip.TabIndex = 3;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // redigeraToolStripMenuItem
            // 
            this.redigeraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.väljFärgToolStripMenuItem,
            this.väljMappToolStripMenuItem,
            this.väljTeckensnittToolStripMenuItem});
            this.redigeraToolStripMenuItem.Name = "redigeraToolStripMenuItem";
            this.redigeraToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.redigeraToolStripMenuItem.Text = "Redigera";
            // 
            // väljFärgToolStripMenuItem
            // 
            this.väljFärgToolStripMenuItem.Name = "väljFärgToolStripMenuItem";
            this.väljFärgToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.väljFärgToolStripMenuItem.Text = "Välj Färg";
            this.väljFärgToolStripMenuItem.Click += new System.EventHandler(this.VäljFärgToolStripMenuItem_Click);
            // 
            // väljMappToolStripMenuItem
            // 
            this.väljMappToolStripMenuItem.Name = "väljMappToolStripMenuItem";
            this.väljMappToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.väljMappToolStripMenuItem.Text = "Välj mapp";
            this.väljMappToolStripMenuItem.Click += new System.EventHandler(this.VäljMappToolStripMenuItem_Click);
            // 
            // väljTeckensnittToolStripMenuItem
            // 
            this.väljTeckensnittToolStripMenuItem.Name = "väljTeckensnittToolStripMenuItem";
            this.väljTeckensnittToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.väljTeckensnittToolStripMenuItem.Text = "Välj teckensnitt";
            this.väljTeckensnittToolStripMenuItem.Click += new System.EventHandler(this.VäljTeckensnittToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 130);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.mnuStrip);
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.FolderBrowserDialog dlgFolderbrowser;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem redigeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem väljFärgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem väljMappToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem väljTeckensnittToolStripMenuItem;
    }
}

