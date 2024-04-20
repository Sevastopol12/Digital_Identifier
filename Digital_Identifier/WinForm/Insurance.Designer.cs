namespace WinForm
{
    partial class Insurance
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
            panel4 = new Panel();
            linkLabel2 = new LinkLabel();
            health_insurance_provider = new Label();
            label11 = new Label();
            provider = new Label();
            end_date = new Label();
            health_insurance_policy_number = new Label();
            health_insurance_end_date = new Label();
            panel1 = new Panel();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(linkLabel2);
            panel4.Controls.Add(health_insurance_provider);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(provider);
            panel4.Controls.Add(end_date);
            panel4.Controls.Add(health_insurance_policy_number);
            panel4.Controls.Add(health_insurance_end_date);
            panel4.Location = new Point(56, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(568, 327);
            panel4.TabIndex = 58;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.Location = new Point(154, 26);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(259, 32);
            linkLabel2.TabIndex = 49;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Health Insurance";
            // 
            // health_insurance_provider
            // 
            health_insurance_provider.AutoSize = true;
            health_insurance_provider.Font = new Font("Verdana", 12F);
            health_insurance_provider.ForeColor = SystemColors.ActiveCaptionText;
            health_insurance_provider.Location = new Point(312, 223);
            health_insurance_provider.Name = "health_insurance_provider";
            health_insurance_provider.Size = new Size(92, 25);
            health_insurance_provider.TabIndex = 55;
            health_insurance_provider.Text = "#####";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(71, 114);
            label11.Name = "label11";
            label11.Size = new Size(181, 25);
            label11.TabIndex = 50;
            label11.Text = "Policy number:";
            // 
            // provider
            // 
            provider.AutoSize = true;
            provider.Font = new Font("Verdana", 12F, FontStyle.Bold);
            provider.ForeColor = SystemColors.ActiveCaptionText;
            provider.Location = new Point(71, 223);
            provider.Name = "provider";
            provider.Size = new Size(116, 25);
            provider.TabIndex = 54;
            provider.Text = "Provider:";
            // 
            // end_date
            // 
            end_date.AutoSize = true;
            end_date.Font = new Font("Verdana", 12F, FontStyle.Bold);
            end_date.ForeColor = SystemColors.ActiveCaptionText;
            end_date.Location = new Point(71, 170);
            end_date.Name = "end_date";
            end_date.Size = new Size(147, 25);
            end_date.TabIndex = 52;
            end_date.Text = "Expiry date:";
            // 
            // health_insurance_policy_number
            // 
            health_insurance_policy_number.AutoSize = true;
            health_insurance_policy_number.Font = new Font("Verdana", 12F);
            health_insurance_policy_number.ForeColor = SystemColors.ActiveCaptionText;
            health_insurance_policy_number.Location = new Point(312, 114);
            health_insurance_policy_number.Name = "health_insurance_policy_number";
            health_insurance_policy_number.Size = new Size(92, 25);
            health_insurance_policy_number.TabIndex = 51;
            health_insurance_policy_number.Text = "#####";
            // 
            // health_insurance_end_date
            // 
            health_insurance_end_date.AutoSize = true;
            health_insurance_end_date.Font = new Font("Verdana", 12F);
            health_insurance_end_date.ForeColor = SystemColors.ActiveCaptionText;
            health_insurance_end_date.Location = new Point(312, 170);
            health_insurance_end_date.Name = "health_insurance_end_date";
            health_insurance_end_date.Size = new Size(92, 25);
            health_insurance_end_date.TabIndex = 53;
            health_insurance_end_date.Text = "#####";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(701, 351);
            panel1.TabIndex = 59;
            // 
            // Insurance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 351);
            Controls.Add(panel1);
            Name = "Insurance";
            Text = "Insurance";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private LinkLabel linkLabel2;
        public Label health_insurance_provider;
        private Label label11;
        private Label provider;
        private Label end_date;
        public Label health_insurance_policy_number;
        public Label health_insurance_end_date;
        private Panel panel1;
    }
}