namespace TreeView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Bataljon");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tvwBataljon = new System.Windows.Forms.TreeView();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.gbxNyenhet = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSoldates = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxInfo = new System.Windows.Forms.TextBox();
            this.gbxNyenhet.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvwBataljon
            // 
            this.tvwBataljon.HideSelection = false;
            this.tvwBataljon.ImageIndex = 0;
            this.tvwBataljon.ImageList = this.icons;
            this.tvwBataljon.Location = new System.Drawing.Point(12, 12);
            this.tvwBataljon.Name = "tvwBataljon";
            treeNode1.Name = "Bataljon";
            treeNode1.Text = "Bataljon";
            this.tvwBataljon.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvwBataljon.SelectedImageIndex = 0;
            this.tvwBataljon.Size = new System.Drawing.Size(233, 260);
            this.tvwBataljon.TabIndex = 0;
            this.tvwBataljon.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwBataljon_AfterSelect);
            // 
            // icons
            // 
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "Bataljon.png");
            this.icons.Images.SetKeyName(1, "Kompani.png");
            this.icons.Images.SetKeyName(2, "Pluton.png");
            this.icons.Images.SetKeyName(3, "Grupp.png");
            // 
            // gbxNyenhet
            // 
            this.gbxNyenhet.Controls.Add(this.btnRemove);
            this.gbxNyenhet.Controls.Add(this.btnNew);
            this.gbxNyenhet.Controls.Add(this.label2);
            this.gbxNyenhet.Controls.Add(this.tbxSoldates);
            this.gbxNyenhet.Controls.Add(this.label1);
            this.gbxNyenhet.Controls.Add(this.tbxName);
            this.gbxNyenhet.Location = new System.Drawing.Point(251, 12);
            this.gbxNyenhet.Name = "gbxNyenhet";
            this.gbxNyenhet.Size = new System.Drawing.Size(243, 143);
            this.gbxNyenhet.TabIndex = 1;
            this.gbxNyenhet.TabStop = false;
            this.gbxNyenhet.Text = "Lägg till ny enhet";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(56, 113);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Radera enhet";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(162, 113);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "Ny enhet";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Antal soldater:";
            // 
            // tbxSoldates
            // 
            this.tbxSoldates.Location = new System.Drawing.Point(105, 63);
            this.tbxSoldates.Name = "tbxSoldates";
            this.tbxSoldates.Size = new System.Drawing.Size(132, 20);
            this.tbxSoldates.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Namn:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(105, 28);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(132, 20);
            this.tbxName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxInfo);
            this.groupBox2.Location = new System.Drawing.Point(252, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 111);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information om vald enhet";
            // 
            // tbxInfo
            // 
            this.tbxInfo.Location = new System.Drawing.Point(7, 20);
            this.tbxInfo.Multiline = true;
            this.tbxInfo.Name = "tbxInfo";
            this.tbxInfo.ReadOnly = true;
            this.tbxInfo.Size = new System.Drawing.Size(229, 85);
            this.tbxInfo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 280);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxNyenhet);
            this.Controls.Add(this.tvwBataljon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxNyenhet.ResumeLayout(false);
            this.gbxNyenhet.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvwBataljon;
        private System.Windows.Forms.GroupBox gbxNyenhet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSoldates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxInfo;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ImageList icons;
    }
}

