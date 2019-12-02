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
            this.components = new System.ComponentModel.Container();
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
            this.btnClose = new System.Windows.Forms.Button();
            this.cmsStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.krypteraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baklängestextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taBortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStrip.SuspendLayout();
            this.cmsStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.ContextMenuStrip = this.cmsStrip;
            this.btnColor.Location = new System.Drawing.Point(31, 29);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(121, 23);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "Välj en färg";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.ContextMenuStrip = this.cmsStrip;
            this.btnFolder.Location = new System.Drawing.Point(31, 58);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(121, 23);
            this.btnFolder.TabIndex = 1;
            this.btnFolder.Text = "Öppna Mappväljaren";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.BtnFolder_Click);
            // 
            // btnFont
            // 
            this.btnFont.ContextMenuStrip = this.cmsStrip;
            this.btnFont.Location = new System.Drawing.Point(31, 87);
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
            this.redigeraToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
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
            this.väljFärgToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.väljFärgToolStripMenuItem.Name = "väljFärgToolStripMenuItem";
            this.väljFärgToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.väljFärgToolStripMenuItem.Text = "Välj Färg";
            this.väljFärgToolStripMenuItem.Click += new System.EventHandler(this.VäljFärgToolStripMenuItem_Click);
            // 
            // väljMappToolStripMenuItem
            // 
            this.väljMappToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.väljMappToolStripMenuItem.Name = "väljMappToolStripMenuItem";
            this.väljMappToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.väljMappToolStripMenuItem.Text = "Välj mapp";
            this.väljMappToolStripMenuItem.Click += new System.EventHandler(this.VäljMappToolStripMenuItem_Click);
            // 
            // väljTeckensnittToolStripMenuItem
            // 
            this.väljTeckensnittToolStripMenuItem.BackColor = System.Drawing.Color.BlueViolet;
            this.väljTeckensnittToolStripMenuItem.Name = "väljTeckensnittToolStripMenuItem";
            this.väljTeckensnittToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.väljTeckensnittToolStripMenuItem.Text = "Välj teckensnitt";
            this.väljTeckensnittToolStripMenuItem.Click += new System.EventHandler(this.VäljTeckensnittToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(130, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // cmsStrip
            // 
            this.cmsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.krypteraToolStripMenuItem,
            this.baklängestextToolStripMenuItem,
            this.taBortToolStripMenuItem});
            this.cmsStrip.Name = "cmsStrip";
            this.cmsStrip.Size = new System.Drawing.Size(181, 92);
            // 
            // krypteraToolStripMenuItem
            // 
            this.krypteraToolStripMenuItem.Name = "krypteraToolStripMenuItem";
            this.krypteraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.krypteraToolStripMenuItem.Text = "Kryptera";
            
            // 
            // baklängestextToolStripMenuItem
            // 
            this.baklängestextToolStripMenuItem.Name = "baklängestextToolStripMenuItem";
            this.baklängestextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.baklängestextToolStripMenuItem.Text = "Baklängestext";
            
            // taBortToolStripMenuItem
            // 
            this.taBortToolStripMenuItem.Name = "taBortToolStripMenuItem";
            this.taBortToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.taBortToolStripMenuItem.Text = "Ta bort";
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 130);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.mnuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.cmsStrip.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip cmsStrip;
        private System.Windows.Forms.ToolStripMenuItem krypteraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baklängestextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taBortToolStripMenuItem;
    }
}

