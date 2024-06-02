namespace DocTemplateGen
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxTemplates;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtExpiryDate;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblExpiryDate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBoxTemplates = new System.Windows.Forms.ListBox();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtExpiryDate = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxTemplates
            // 
            this.listBoxTemplates.FormattingEnabled = true;
            this.listBoxTemplates.ItemHeight = 16;
            this.listBoxTemplates.Location = new System.Drawing.Point(12, 12);
            this.listBoxTemplates.Name = "listBoxTemplates";
            this.listBoxTemplates.Size = new System.Drawing.Size(776, 132);
            this.listBoxTemplates.TabIndex = 0;
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(12, 430);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(658, 22);
            this.txtOutputPath.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(12, 171);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(12, 215);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 22);
            this.txtLastName.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 259);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(12, 303);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 22);
            this.txtProductName.TabIndex = 5;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(12, 347);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(200, 22);
            this.txtDiscount.TabIndex = 6;
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.Location = new System.Drawing.Point(12, 391);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Size = new System.Drawing.Size(200, 22);
            this.txtExpiryDate.TabIndex = 7;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(222, 458);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(386, 29);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Згенерувати";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(676, 429);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(112, 23);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "Огляд...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 152);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(32, 16);
            this.lblFirstName.TabIndex = 10;
            this.lblFirstName.Text = "Ім\'я:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 196);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(72, 16);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Прізвище:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 240);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(12, 284);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(117, 16);
            this.lblProductName.TabIndex = 13;
            this.lblProductName.Text = "Назва продукту:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(12, 328);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(59, 16);
            this.lblDiscount.TabIndex = 14;
            this.lblDiscount.Text = "Знижка:";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new System.Drawing.Point(11, 372);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(118, 16);
            this.lblExpiryDate.TabIndex = 15;
            this.lblExpiryDate.Text = "Дата закінчення:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtExpiryDate);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.listBoxTemplates);
            this.Name = "MainForm";
            this.Text = "Генератор документів";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
