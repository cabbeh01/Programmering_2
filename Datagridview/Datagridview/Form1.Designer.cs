namespace Datagridview
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colHemmaLag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBortalag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMålHemma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMålBorta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.btnMålrikast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHemmaLag,
            this.colBortalag,
            this.colMålHemma,
            this.colMålBorta});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 491);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // colHemmaLag
            // 
            this.colHemmaLag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHemmaLag.HeaderText = "Hemmalag";
            this.colHemmaLag.Name = "colHemmaLag";
            // 
            // colBortalag
            // 
            this.colBortalag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBortalag.HeaderText = "Bortalag";
            this.colBortalag.Name = "colBortalag";
            // 
            // colMålHemma
            // 
            this.colMålHemma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMålHemma.HeaderText = "Mål (H)";
            this.colMålHemma.Name = "colMålHemma";
            // 
            // colMålBorta
            // 
            this.colMålBorta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMålBorta.HeaderText = "Mål (B)";
            this.colMålBorta.Name = "colMålBorta";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 491);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbxInput);
            this.panel2.Controls.Add(this.btnMålrikast);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 57);
            this.panel2.TabIndex = 2;
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(151, 19);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(263, 20);
            this.tbxInput.TabIndex = 1;
            this.tbxInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnMålrikast
            // 
            this.btnMålrikast.Location = new System.Drawing.Point(3, 3);
            this.btnMålrikast.Name = "btnMålrikast";
            this.btnMålrikast.Size = new System.Drawing.Size(142, 51);
            this.btnMålrikast.TabIndex = 0;
            this.btnMålrikast.Text = "Målrikast";
            this.btnMålrikast.UseVisualStyleBackColor = true;
            this.btnMålrikast.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Button btnMålrikast;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHemmaLag;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBortalag;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMålHemma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMålBorta;
    }
}

