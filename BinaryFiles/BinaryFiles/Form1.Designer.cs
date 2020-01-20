namespace BinaryFiles
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
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öppnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaSomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxMangd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMatt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.colIngred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMangd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(532, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öppnaToolStripMenuItem,
            this.sparaSomToolStripMenuItem});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // öppnaToolStripMenuItem
            // 
            this.öppnaToolStripMenuItem.Name = "öppnaToolStripMenuItem";
            this.öppnaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öppnaToolStripMenuItem.Text = "Öppna";
            this.öppnaToolStripMenuItem.Click += new System.EventHandler(this.ÖppnaToolStripMenuItem_Click);
            // 
            // sparaSomToolStripMenuItem
            // 
            this.sparaSomToolStripMenuItem.Name = "sparaSomToolStripMenuItem";
            this.sparaSomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sparaSomToolStripMenuItem.Text = "Spara som...";
            this.sparaSomToolStripMenuItem.Click += new System.EventHandler(this.SparaSomToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Namn";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(125, 42);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(183, 20);
            this.tbxName.TabIndex = 2;
            // 
            // tbxMangd
            // 
            this.tbxMangd.Location = new System.Drawing.Point(125, 68);
            this.tbxMangd.Name = "tbxMangd";
            this.tbxMangd.Size = new System.Drawing.Size(183, 20);
            this.tbxMangd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mängd";
            // 
            // tbxMatt
            // 
            this.tbxMatt.Location = new System.Drawing.Point(125, 94);
            this.tbxMatt.Name = "tbxMatt";
            this.tbxMatt.Size = new System.Drawing.Size(183, 20);
            this.tbxMatt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mått";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(401, 92);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Lägg till";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // dgView
            // 
            this.dgView.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIngred,
            this.colMangd,
            this.colMatt});
            this.dgView.Location = new System.Drawing.Point(12, 126);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(508, 312);
            this.dgView.TabIndex = 8;
            // 
            // colIngred
            // 
            this.colIngred.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colIngred.HeaderText = "Ingredienser";
            this.colIngred.Name = "colIngred";
            // 
            // colMangd
            // 
            this.colMangd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMangd.HeaderText = "Mängd";
            this.colMangd.Name = "colMangd";
            // 
            // colMatt
            // 
            this.colMatt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMatt.HeaderText = "Mått";
            this.colMatt.Name = "colMatt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxMatt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxMangd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Recept";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öppnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaSomToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxMangd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMatt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIngred;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMangd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatt;
    }
}

