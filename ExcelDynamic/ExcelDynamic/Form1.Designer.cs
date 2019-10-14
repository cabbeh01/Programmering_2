namespace ExcelDynamic
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxClass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCourse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tbxRow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(135, 27);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(177, 20);
            this.tbxName.TabIndex = 1;
            // 
            // tbxClass
            // 
            this.tbxClass.Location = new System.Drawing.Point(135, 53);
            this.tbxClass.Name = "tbxClass";
            this.tbxClass.Size = new System.Drawing.Size(177, 20);
            this.tbxClass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Klass";
            // 
            // tbxCourse
            // 
            this.tbxCourse.Location = new System.Drawing.Point(135, 79);
            this.tbxCourse.Name = "tbxCourse";
            this.tbxCourse.Size = new System.Drawing.Size(177, 20);
            this.tbxCourse.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kurs";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(171, 131);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(141, 23);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "Öppna Excel";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // tbxRow
            // 
            this.tbxRow.Location = new System.Drawing.Point(135, 169);
            this.tbxRow.Name = "tbxRow";
            this.tbxRow.Size = new System.Drawing.Size(71, 20);
            this.tbxRow.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Radnummer";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(212, 167);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 23);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Exportera";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(212, 196);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(100, 23);
            this.btnImport.TabIndex = 10;
            this.btnImport.Text = "Importera";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(135, 254);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(177, 23);
            this.btnSaveClose.TabIndex = 11;
            this.btnSaveClose.Text = "Spara och Stäng";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 300);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.tbxRow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.tbxCourse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox tbxRow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSaveClose;
    }
}

