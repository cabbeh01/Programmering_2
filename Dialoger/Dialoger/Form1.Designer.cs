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
            this.cmsStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.krypteraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baklängestextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taBortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.cmsStrip.SuspendLayout();
            this.mnuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.toolTip1.SetToolTip(this.btnColor, "Här väljer du en färg");
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // cmsStrip
            // 
            this.cmsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.krypteraToolStripMenuItem,
            this.baklängestextToolStripMenuItem,
            this.taBortToolStripMenuItem});
            this.cmsStrip.Name = "cmsStrip";
            this.cmsStrip.Size = new System.Drawing.Size(147, 70);
            // 
            // krypteraToolStripMenuItem
            // 
            this.krypteraToolStripMenuItem.Name = "krypteraToolStripMenuItem";
            this.krypteraToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.krypteraToolStripMenuItem.Text = "Kryptera";
            // 
            // baklängestextToolStripMenuItem
            // 
            this.baklängestextToolStripMenuItem.Name = "baklängestextToolStripMenuItem";
            this.baklängestextToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.baklängestextToolStripMenuItem.Text = "Baklängestext";
            // 
            // taBortToolStripMenuItem
            // 
            this.taBortToolStripMenuItem.Name = "taBortToolStripMenuItem";
            this.taBortToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.taBortToolStripMenuItem.Text = "Ta bort";
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
            this.mnuStrip.Size = new System.Drawing.Size(658, 24);
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
            this.väljFärgToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.väljFärgToolStripMenuItem.Text = "Välj Färg";
            this.väljFärgToolStripMenuItem.Click += new System.EventHandler(this.VäljFärgToolStripMenuItem_Click);
            // 
            // väljMappToolStripMenuItem
            // 
            this.väljMappToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.väljMappToolStripMenuItem.Name = "väljMappToolStripMenuItem";
            this.väljMappToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.väljMappToolStripMenuItem.Text = "Välj mapp";
            this.väljMappToolStripMenuItem.Click += new System.EventHandler(this.VäljMappToolStripMenuItem_Click);
            // 
            // väljTeckensnittToolStripMenuItem
            // 
            this.väljTeckensnittToolStripMenuItem.BackColor = System.Drawing.Color.BlueViolet;
            this.väljTeckensnittToolStripMenuItem.Name = "väljTeckensnittToolStripMenuItem";
            this.väljTeckensnittToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(275, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(339, 187);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(331, 161);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Musik";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(221, 119);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Film";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(221, 119);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ljudböcker";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(221, 119);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Podradio";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(221, 119);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Appar";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 286);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.mnuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.cmsStrip.ResumeLayout(false);
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
    }
}

