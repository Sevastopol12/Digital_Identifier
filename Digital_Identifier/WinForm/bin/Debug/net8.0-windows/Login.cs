using System;
using System.Drawing;
using System.Windows.Forms;
using Digital_Identifier;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static Digital_Identifier.DigiDen;


namespace WinForm
{

    public partial class Login : Form
    {
        private DigiDen identifier = new DigiDen();
        public User user = new User();


        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            long ID;
            string password;

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Your ID is empty", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }

            if (!long.TryParse(textBox1.Text, out ID))
            {
                MessageBox.Show("Invalid ID", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            ID = long.Parse(textBox1.Text);

            if (string.IsNullOrEmpty(textBox2.Text)) 
            {
                MessageBox.Show("Your password is empty", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return;
            }
            password = textBox2.Text.Trim();

            Dictionary<string, string> result = identifier.Search(ID, password);

            if (result is not null) 
            {
                user.SSN = ID.ToString();
                user.password = password;
                user.data = result;
                this.Hide();
                user.ShowDialog();
                this.Show();
            }
            else { label3.Text = "Not found"; }

            
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Exit?", "Notification!!", MessageBoxButtons.OKCancel) != DialogResult.OK) { e.Cancel = true; }
        }

        private void a_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi?", "Hello, World!!", MessageBoxButtons.OKCancel);
        }
    }
}
