using SAV_E_commerce;
using System.Data.SQLite;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SAV_E_commerce
{
    public partial class LoginForm : Form
    {
        Login log = new Login(@"Data Source= C:\\sqlite\\SQLiteDatabaseBrowserPortable\\SAV_ecommerce.db;Version=3;");
        Database db = new Database(@"Data Source= C:\\sqlite\\SQLiteDatabaseBrowserPortable\\SAV_ecommerce.db;Version=3;");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Inscription_button_Click(object sender, EventArgs e)
        {
            Form inscription = new InscriptionForm();
            inscription.Show();
            if(log.IsAuthenticated)
            {
                inscription.Hide();
            }
        }

        private void Connect_button_Click(object sender, EventArgs e)
        {
            log.AuthenticateUser(username_textBox.Text, password_textBox.Text);
            Form accueil = new AccueilForm();
            if (log.IsAuthenticated)
            {
                accueil.Show();
                this.Hide();
            }
        }
    }
}
