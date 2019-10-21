namespace Mediabiblioteket
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTitleBook = new System.Windows.Forms.TextBox();
            this.tbxPagesBook = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegisterBook = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRegisterAudio = new System.Windows.Forms.Button();
            this.tbxPlaytimeAudio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTitleAudio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRegisterMovie = new System.Windows.Forms.Button();
            this.tbxPlaytimeMovie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxTitleMovie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbxOut = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxResolutionMovie = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegisterBook);
            this.groupBox1.Controls.Add(this.tbxPagesBook);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxTitleBook);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bok";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titel";
            // 
            // tbxTitleBook
            // 
            this.tbxTitleBook.Location = new System.Drawing.Point(84, 24);
            this.tbxTitleBook.Name = "tbxTitleBook";
            this.tbxTitleBook.Size = new System.Drawing.Size(100, 20);
            this.tbxTitleBook.TabIndex = 1;
            // 
            // tbxPagesBook
            // 
            this.tbxPagesBook.Location = new System.Drawing.Point(84, 50);
            this.tbxPagesBook.Name = "tbxPagesBook";
            this.tbxPagesBook.Size = new System.Drawing.Size(100, 20);
            this.tbxPagesBook.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Antal sidor";
            // 
            // btnRegisterBook
            // 
            this.btnRegisterBook.Location = new System.Drawing.Point(19, 100);
            this.btnRegisterBook.Name = "btnRegisterBook";
            this.btnRegisterBook.Size = new System.Drawing.Size(165, 23);
            this.btnRegisterBook.TabIndex = 1;
            this.btnRegisterBook.Text = "Registrera bok";
            this.btnRegisterBook.UseVisualStyleBackColor = true;
            this.btnRegisterBook.Click += new System.EventHandler(this.BtnRegisterBook_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRegisterAudio);
            this.groupBox2.Controls.Add(this.tbxPlaytimeAudio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbxTitleAudio);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(226, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 129);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ljudspår";
            // 
            // btnRegisterAudio
            // 
            this.btnRegisterAudio.Location = new System.Drawing.Point(19, 100);
            this.btnRegisterAudio.Name = "btnRegisterAudio";
            this.btnRegisterAudio.Size = new System.Drawing.Size(165, 23);
            this.btnRegisterAudio.TabIndex = 1;
            this.btnRegisterAudio.Text = "Registrera ljudspår";
            this.btnRegisterAudio.UseVisualStyleBackColor = true;
            this.btnRegisterAudio.Click += new System.EventHandler(this.BtnRegisterAudio_Click);
            // 
            // tbxPlaytimeAudio
            // 
            this.tbxPlaytimeAudio.Location = new System.Drawing.Point(84, 50);
            this.tbxPlaytimeAudio.Name = "tbxPlaytimeAudio";
            this.tbxPlaytimeAudio.Size = new System.Drawing.Size(100, 20);
            this.tbxPlaytimeAudio.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Speltid";
            // 
            // tbxTitleAudio
            // 
            this.tbxTitleAudio.Location = new System.Drawing.Point(84, 24);
            this.tbxTitleAudio.Name = "tbxTitleAudio";
            this.tbxTitleAudio.Size = new System.Drawing.Size(100, 20);
            this.tbxTitleAudio.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Titel";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxResolutionMovie);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnRegisterMovie);
            this.groupBox3.Controls.Add(this.tbxPlaytimeMovie);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbxTitleMovie);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(440, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 129);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Film";
            // 
            // btnRegisterMovie
            // 
            this.btnRegisterMovie.Location = new System.Drawing.Point(19, 100);
            this.btnRegisterMovie.Name = "btnRegisterMovie";
            this.btnRegisterMovie.Size = new System.Drawing.Size(165, 23);
            this.btnRegisterMovie.TabIndex = 1;
            this.btnRegisterMovie.Text = "Registrera film";
            this.btnRegisterMovie.UseVisualStyleBackColor = true;
            this.btnRegisterMovie.Click += new System.EventHandler(this.BtnRegisterMovie_Click);
            // 
            // tbxPlaytimeMovie
            // 
            this.tbxPlaytimeMovie.Location = new System.Drawing.Point(84, 50);
            this.tbxPlaytimeMovie.Name = "tbxPlaytimeMovie";
            this.tbxPlaytimeMovie.Size = new System.Drawing.Size(100, 20);
            this.tbxPlaytimeMovie.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Speltid";
            // 
            // tbxTitleMovie
            // 
            this.tbxTitleMovie.Location = new System.Drawing.Point(84, 24);
            this.tbxTitleMovie.Name = "tbxTitleMovie";
            this.tbxTitleMovie.Size = new System.Drawing.Size(100, 20);
            this.tbxTitleMovie.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Titel";
            // 
            // lbxOut
            // 
            this.lbxOut.FormattingEnabled = true;
            this.lbxOut.Location = new System.Drawing.Point(12, 193);
            this.lbxOut.Name = "lbxOut";
            this.lbxOut.Size = new System.Drawing.Size(636, 238);
            this.lbxOut.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(256, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "BIBLIOTEK";
            // 
            // tbxResolutionMovie
            // 
            this.tbxResolutionMovie.Location = new System.Drawing.Point(84, 74);
            this.tbxResolutionMovie.Name = "tbxResolutionMovie";
            this.tbxResolutionMovie.Size = new System.Drawing.Size(100, 20);
            this.tbxResolutionMovie.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Upplösning";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbxOut);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegisterBook;
        private System.Windows.Forms.TextBox tbxPagesBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTitleBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRegisterAudio;
        private System.Windows.Forms.TextBox tbxPlaytimeAudio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxTitleAudio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbxResolutionMovie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRegisterMovie;
        private System.Windows.Forms.TextBox tbxPlaytimeMovie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxTitleMovie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbxOut;
        private System.Windows.Forms.Label label7;
    }
}

