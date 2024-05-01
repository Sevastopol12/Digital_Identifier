using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Digital_Identifier.DigiDen;

namespace WinForm
{
    public partial class User : Form
    {
        public string SSN = null;
        public string password = null;
        public Dictionary<string, string> data = new Dictionary<string, string>();
        private License my_license = new License();
        private Update update = new Update();
        private Insurance my_insurance = new Insurance();
        public User()
        {
            InitializeComponent();
        }


        private void User_Load(object sender, EventArgs e)
        {
            ssn.Text = SSN;
            first_name.Text = data["first_name"];
            last_name.Text = data["last_name"];
            age.Text = data["age"];
            email.Text = data["email"];
            nation.Text = data["nation"];
            postal_code.Text = data["postal_code"];
            gender.Text = data["gender"];
            birthdate.Text = data["birthdate"];
            phone_number.Text = data["phone_number"];
            height.Text = data["height"];
            weight.Text = data["weight"];
            blood_type.Text = data["blood_type"];
            ethnicity.Text = data["ethnicity"];
            occupation.Text = data["occupation"];
            education_level.Text = data["education_level"];
            address_street.Text = data["address_street"];
            address_city.Text = data["address_city"];
            hometown.Text = data["hometown"];
            address_state.Text = data["address_state"];
            religion.Text = data["religion"];

        }


        private void license_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            my_license.driver_license.Text = data["driver_license"];
            my_license.license_expiry_date.Text = data["license_expiry_date"];
            my_license.license_issued_by.Text = data["license_issued_by"];
            my_license.ShowDialog();
            this.Show();
        }

        private void Insurance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            my_insurance.health_insurance_provider.Text = data["health_insurance_provider"];
            my_insurance.health_insurance_policy_number.Text = data["health_insurance_policy_number"];
            my_insurance.health_insurance_end_date.Text = data["health_insurance_end_date"];
            my_insurance.ShowDialog();
            this.Show();

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update.SSN = SSN;
            update.password = password;
            update.data = data;
            this.Hide();
            update.ShowDialog();
            this.Show();
        }
    }
}
