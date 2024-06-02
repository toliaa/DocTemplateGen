namespace DocTemplateGen
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null; // Component container
        private System.Windows.Forms.ListBox listBoxTemplates; // ListBox for template selection
        private System.Windows.Forms.TextBox txtOutputPath; // TextBox for output path
        private System.Windows.Forms.TextBox txtFirstName; // TextBox for first name
        private System.Windows.Forms.TextBox txtLastName; // TextBox for last name
        private System.Windows.Forms.TextBox txtEmail; // TextBox for email
        private System.Windows.Forms.TextBox txtProductName; // TextBox for product name
        private System.Windows.Forms.TextBox txtDiscount; // TextBox for discount
        private System.Windows.Forms.TextBox txtExpiryDate; // TextBox for expiry date
        private System.Windows.Forms.Button btnGenerate; // Button to generate document
        private System.Windows.Forms.Button btnBrowse; // Button to browse output path
        private System.Windows.Forms.Label lblFirstName; // Label for first name
        private System.Windows.Forms.Label lblLastName; // Label for last name
        private System.Windows.Forms.Label lblEmail; // Label for email
        private System.Windows.Forms.Label lblProductName; // Label for product name
        private System.Windows.Forms.Label lblDiscount; // Label for discount
        private System.Windows.Forms.Label lblExpiryDate; // Label for expiry date

        // Dispose method to clean up resources
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Initialize components and form layout
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.txtFirstName.Location = new System.Drawing.Point(12, 170);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(12, 210);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 22);
            this.txtLastName.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 250);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(12, 290);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 22);
            this.txtProductName.TabIndex = 5;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(12, 330);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(200, 22);
            this.txtDiscount.TabIndex = 6;
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.Location = new System.Drawing.Point(12, 370);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Size = new System.Drawing.Size(200, 22);
            this.txtExpiryDate.TabIndex = 7;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 470);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(776, 37);
            this.btnGenerate.TabIndex = 14;
            this.btnGenerate.Text = "Generate Document";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(676, 429);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(112, 23);
            this.btnBrowse.TabIndex = 15;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 150);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(75, 16);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 190);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(75, 16);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 230);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(12, 270);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(96, 16);
            this.lblProductName.TabIndex = 11;
            this.lblProductName.Text = "Product Name:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(12, 310);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(62, 16);
            this.lblDiscount.TabIndex = 12;
            this.lblDiscount.Text = "Discount:";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new System.Drawing.Point(12, 350);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(79, 16);
            this.lblExpiryDate.TabIndex = 13;
            this.lblExpiryDate.Text = "Expiry Date:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Document Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
