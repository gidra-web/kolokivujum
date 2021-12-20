namespace PresentationLayer
{
    partial class Studenti
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
            this.listBoxStudent = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxIndexNumber = new System.Windows.Forms.TextBox();
            this.textBoxAverageMark = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxStudent
            // 
            this.listBoxStudent.FormattingEnabled = true;
            this.listBoxStudent.ItemHeight = 16;
            this.listBoxStudent.Location = new System.Drawing.Point(43, 32);
            this.listBoxStudent.Name = "listBoxStudent";
            this.listBoxStudent.Size = new System.Drawing.Size(709, 340);
            this.listBoxStudent.TabIndex = 0;
            this.listBoxStudent.SelectedIndexChanged += new System.EventHandler(this.listBoxStudent_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj Indeksa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prosek";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(150, 404);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(157, 22);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxIndexNumber
            // 
            this.textBoxIndexNumber.Location = new System.Drawing.Point(150, 452);
            this.textBoxIndexNumber.Name = "textBoxIndexNumber";
            this.textBoxIndexNumber.Size = new System.Drawing.Size(157, 22);
            this.textBoxIndexNumber.TabIndex = 5;
            // 
            // textBoxAverageMark
            // 
            this.textBoxAverageMark.Location = new System.Drawing.Point(150, 499);
            this.textBoxAverageMark.Name = "textBoxAverageMark";
            this.textBoxAverageMark.Size = new System.Drawing.Size(157, 22);
            this.textBoxAverageMark.TabIndex = 6;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(353, 495);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(123, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert Student";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Studenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 541);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.textBoxAverageMark);
            this.Controls.Add(this.textBoxIndexNumber);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxStudent);
            this.Name = "Studenti";
            this.Text = "Studenti";
            this.Load += new System.EventHandler(this.Studenti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxIndexNumber;
        private System.Windows.Forms.TextBox textBoxAverageMark;
        private System.Windows.Forms.Button btnInsert;
    }
}

