namespace PresentationLayerShop
{
    partial class ShopApp
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
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.dtp_expireDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 16;
            this.listBoxProducts.Location = new System.Drawing.Point(43, 21);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(731, 292);
            this.listBoxProducts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Expire Date";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(140, 329);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(175, 22);
            this.tb_name.TabIndex = 4;
            // 
            // tb_description
            // 
            this.tb_description.Location = new System.Drawing.Point(140, 370);
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(175, 22);
            this.tb_description.TabIndex = 5;
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_insert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_insert.Location = new System.Drawing.Point(385, 385);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(87, 48);
            this.btn_insert.TabIndex = 7;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtp_expireDate
            // 
            this.dtp_expireDate.Location = new System.Drawing.Point(140, 414);
            this.dtp_expireDate.Name = "dtp_expireDate";
            this.dtp_expireDate.Size = new System.Drawing.Size(200, 22);
            this.dtp_expireDate.TabIndex = 8;
            // 
            // ShopApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 479);
            this.Controls.Add(this.dtp_expireDate);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxProducts);
            this.Name = "ShopApp";
            this.Text = "Proizvodi";
            this.Load += new System.EventHandler(this.ShopApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.DateTimePicker dtp_expireDate;
    }
}

