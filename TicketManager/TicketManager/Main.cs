using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using TicketManager.DataLayer;

namespace TicketManager
{
    public partial class Main : Form
    {
        //establish connection to sql database
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TicketManager.Properties.Settings.TicketManagerConnectionString"].ConnectionString);

        public Main()
        {
            InitializeComponent();
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            Worker w = new Worker();
            bool result = w.saveWorker(tbWorkerName.Text);

            disp_data();

            tbWorkerName.Text = "";

            MessageBox.Show("Record updated");
        }

        //update datagridview customer database
        public void disp_data()
        {
            Worker w = new Worker();
            dgvCustomerDB.DataSource = w.getAllWorkers();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketManagerDataSet2.techs' table. You can move, or remove it, as needed.
            //this.techsTableAdapter.Fill(this.ticketManagerDataSet2.techs);

            disp_data();
            cbTech.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            //On live tickets, search by customer ID, auto-fill form fields with customer details
            string sql;
            sql = "Select * from customerDB where ID = '" + 1 + "'";
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            DataSet data = new DataSet();
            var adapter = new SqlDataAdapter(com);
            adapter.Fill(data);
            int count = data.Tables[0].Rows.Count;
            con.Close();
            if (count > 0)
            {
                tbClient.Text = data.Tables[0].Rows[0]["client"].ToString();
            }
            else
            {
                MessageBox.Show("Invalid ID", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //add new task to datagridview
            dgvLiveTickets.Rows.Add(tbClient.Text, cbTech.Text, rtbDescription.Text, monthCalendar1.SelectionRange.Start.ToShortDateString());

            tbClient.Text = "";
            rtbDescription.Text = "";
            cbTech.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //add completed task to datagridview completed tasks
            foreach (DataGridViewRow selRow in dgvLiveTickets.SelectedRows.OfType<DataGridViewRow>().ToArray())
            {
                dgvLiveTickets.Rows.Remove(selRow);
                dgvClosedTickets.Rows.Add(selRow);
            }
        }

        private void btnDeleteLive_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selRow in dgvLiveTickets.SelectedRows.OfType<DataGridViewRow>().ToArray())
            {
                dgvLiveTickets.Rows.Remove(selRow);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            //open excel and transfer data from datagridview
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet
                worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported from Ticket Manager";

            for (int i = 1; i < dgvClosedTickets.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvClosedTickets.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgvClosedTickets.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvClosedTickets.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvClosedTickets.Rows[i].Cells[j].Value.ToString();
                }
            }

            workbook.SaveAs("c:\\ClosedTickets.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);

        }

        private void btnDeleteClosed_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selRow in dgvClosedTickets.SelectedRows.OfType<DataGridViewRow>().ToArray())
            {
                dgvClosedTickets.Rows.Remove(selRow);


                tbTotal.Text = (from DataGridViewRow row in dgvClosedTickets.Rows
                                where row.Cells[7].FormattedValue.ToString() != string.Empty
                                select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
            }
        }

        private void dgvCustomerDB_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
            //uninstallButtonColumn.Name = "enable_worker_column";
            //uninstallButtonColumn.Text = "Habilitar/Deshabilitar";
            //uninstallButtonColumn.UseColumnTextForButtonValue = true;
            //int columnIndex = 2;
            //if (dgvCustomerDB.Columns["uninstall_column"] == null)
            //{
            //    dgvCustomerDB.Columns.Insert(columnIndex, uninstallButtonColumn);
            //}
        }
    }
}
