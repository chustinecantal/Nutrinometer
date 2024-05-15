using MySql.Data.MySqlClient;

namespace Nutrinometer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Database db = new Database("localhost", "Nutrinometer", "root", "btsarmy0122");
            db.CreateTables();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            SignUp sign = new SignUp();
            sign.ShowDialog();
            this.Hide();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txtbox_username.Text;
            string password = txtbox_pass.Text;

            // Create an instance of UserDashboard
            UserDashboard userDashboard = new UserDashboard();

            // Call the AuthenticateAndShow method with username and password
            userDashboard.AuthenticateAndShow(username, password);
        }

        private void txtbox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
