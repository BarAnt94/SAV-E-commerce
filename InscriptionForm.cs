using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SAV_E_commerce
{
    public partial class InscriptionForm : Form
    {
        Login login = new(@"Data Source= C:\\sqlite\\SQLiteDatabaseBrowserPortable\\SAV_ecommerce.db;Version=3;");
        public InscriptionForm()
        {
            InitializeComponent();
        }

        private void Confirm_inscription_button_Click(object sender, EventArgs e)
        {
            string username = username_textBox.Text;
            string email = email_textBox.Text;
            string phone = phone_textBox.Text;
            string password = password_textBox.Text;
            string confirmPassword = confirm_password_textBox.Text;
            login.Inscription(username, email, phone, password, confirmPassword);
        }
    }
}
