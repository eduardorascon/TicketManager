using System;
using System.Windows.Forms;
using TicketManager.DataLayer;

namespace TicketManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            displayUsernames();
        }

        private void displayUsernames()
        {
            UserLogin l = new UserLogin();
            cbUsername.DataSource = l.getAllUsernames();
            cbUsername.DisplayMember = "username";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UserLogin l = new UserLogin();
            bool login = l.login(cbUsername.Text.Trim(), tbPassword.Text.Trim()).Rows.Count > 0;
            if (login)
            {
                MessageBox.Show("Bienvenido");

                Main objMain = new Main();
                this.Hide();
                objMain.Show();
            }
            else
            {
                MessageBox.Show("Datos de ingreso incorrectos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
