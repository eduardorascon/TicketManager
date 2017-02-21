using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            // TODO: This line of code loads data into the 'ticketManagerDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.ticketManagerDataSet.users);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Initial Catalog=TicketManager;Integrated Security=True");
            string query = "select * from users where username = '" + cbUsername.Text.Trim() + "' and password = '" + tbPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count == 1)
            {

                MessageBox.Show("Welcome to Ticket Manager " + cbUsername.Text);

                Main objMain = new Main();
                this.Hide();
                objMain.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
