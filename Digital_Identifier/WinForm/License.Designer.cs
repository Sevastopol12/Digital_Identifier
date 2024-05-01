namespace WinForm
{
    partial class License
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
        public void InitializeComponent()
        {
            license_issued_by = new Label();
            Dprovider = new Label();
            license_expiry_date = new Label();
            label9 = new Label();
            driver_license = new Label();
            adriver_license = new Label();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // license_issued_by
            // 
            license_issued_by.AutoSize = true;
            license_issued_by.Font = new Font("Verdana", 12F);
            license_issued_by.ForeColor = SystemColors.ActiveCaptionText;
            license_issued_by.Location = new Point(267, 201);
            license_issued_by.Name = "license_issued_by";
            license_issued_by.Size = new Size(92, 25);
            license_issued_by.TabIndex = 47;
            license_issued_by.Text = "#####";
            // 
            // Dprovider
            // 
            Dprovider.AutoSize = true;
            Dprovider.Font = new Font("Verdana", 12F, FontStyle.Bold);
            Dprovider.ForeColor = SystemColors.ActiveCaptionText;
            Dprovider.Location = new Point(40, 201);
            Dprovider.Name = "Dprovider";
            Dprovider.Size = new Size(116, 25);
            Dprovider.TabIndex = 46;
            Dprovider.Text = "Provider:";
            // 
            // license_expiry_date
            // 
            license_expiry_date.AutoSize = true;
            license_expiry_date.Font = new Font("Verdana", 12F);
            license_expiry_date.ForeColor = SystemColors.ActiveCaptionText;
            license_expiry_date.Location = new Point(267, 148);
            license_expiry_date.Name = "license_expiry_date";
            license_expiry_date.Size = new Size(92, 25);
            license_expiry_date.TabIndex = 45;
            license_expiry_date.Text = "#####";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(40, 148);
            label9.Name = "label9";
            label9.Size = new Size(147, 25);
            label9.TabIndex = 44;
            label9.Text = "Expiry date:";
            // 
            // driver_license
            // 
            driver_license.AutoSize = true;
            driver_license.Font = new Font("Verdana", 12F);
            driver_license.ForeColor = SystemColors.ActiveCaptionText;
            driver_license.Location = new Point(267, 92);
            driver_license.Name = "driver_license";
            driver_license.Size = new Size(92, 25);
            driver_license.TabIndex = 43;
            driver_license.Text = "#####";
            // 
            // adriver_license
            // 
            adriver_license.AutoSize = true;
            adriver_license.Font = new Font("Verdana", 12F, FontStyle.Bold);
            adriver_license.ForeColor = SystemColors.ActiveCaptionText;
            adriver_license.Location = new Point(40, 92);
            adriver_license.Name = "adriver_license";
            adriver_license.Size = new Size(175, 25);
            adriver_license.TabIndex = 42;
            adriver_license.Text = "Driver license:";
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(license_issued_by);
            panel1.Controls.Add(Dprovider);
            panel1.Controls.Add(license_expiry_date);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(driver_license);
            panel1.Controls.Add(adriver_license);
            panel1.Location = new Point(31, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 258);
            panel1.TabIndex = 48;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Blue;
            linkLabel1.Location = new Point(95, 23);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(240, 32);
            linkLabel1.TabIndex = 48;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Driver's License";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(536, 342);
            panel2.TabIndex = 49;
            // 
            // License
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 342);
            Controls.Add(panel2);
            Name = "License";
            Text = "License";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public Label license_issued_by;
        private Label Dprovider;
        public Label license_expiry_date;
        private Label label9;
        public Label driver_license;
        private Label adriver_license;
        private Panel panel1;
        private Panel panel2;
        private LinkLabel linkLabel1;
    }
}