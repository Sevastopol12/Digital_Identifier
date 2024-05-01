namespace WinForm
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            textBox1 = new TextBox();
            button2 = new Button();
            textBox2 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            a = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(314, 114);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "User-SSN";
            textBox1.Size = new Size(335, 28);
            textBox1.TabIndex = 1;
            textBox1.Text = "322454266";
            textBox1.UseWaitCursor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = Color.Red;
            button2.Font = new Font("Cooper Black", 9.2F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(534, 227);
            button2.Name = "button2";
            button2.Size = new Size(104, 27);
            button2.TabIndex = 4;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Cursor = Cursors.SizeAll;
            textBox2.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(314, 170);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(335, 28);
            textBox2.TabIndex = 2;
            textBox2.Text = "wH5<p|5T3<PWE*4";
            textBox2.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.LimeGreen;
            button1.Font = new Font("Cooper Black", 9.2F);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(424, 227);
            button1.Name = "button1";
            button1.Size = new Size(104, 27);
            button1.TabIndex = 3;
            button1.Text = "Log-In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(75, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(400, 50);
            label3.Name = "label3";
            label3.Size = new Size(153, 46);
            label3.TabIndex = 31;
            label3.Text = "Status";
            // 
            // a
            // 
            a.Location = new Point(664, 63);
            a.Name = "a";
            a.Size = new Size(94, 29);
            a.TabIndex = 33;
            a.Text = "hi";
            a.UseVisualStyleBackColor = true;
            a.Click += a_Click;
            // 
            // Login
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ButtonHighlight;
            CancelButton = button2;
            ClientSize = new Size(777, 328);
            Controls.Add(a);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(button2);
            ForeColor = Color.CornflowerBlue;
            Name = "Login";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button2;
        private TextBox textBox2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label3;
        private Button a;
    }
}
