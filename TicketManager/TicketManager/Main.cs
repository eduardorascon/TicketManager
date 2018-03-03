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
        public Main()
        {
            InitializeComponent();
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            Worker w = new Worker();
            bool result = w.saveWorker(tbWorkerName.Text);

            disp_data();
            displayWorkers();

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
            disp_data();
            displayTasks();
            displayWorkers();
        }

        private void displayWorkers()
        {
            Worker w = new Worker();
            cbWorker.DataSource = w.getAllEnabledWorkers();
            cbWorker.DisplayMember = "workerName";
        }

        private void displayTasks()
        {
            Task t = new Task();
            dgvLiveTickets.DataSource = t.getAllActiveTasks();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Task t = new Task();

            int workerId = Worker.searchByName(cbWorker.Text);
            bool result = t.saveTask(tbTaskName.Text, rtbTaskDescription.Text, mcTaskDateRange.SelectionStart, mcTaskDateRange.SelectionEnd, workerId);

            displayTasks();

            tbTaskName.Text = "";
            tbWorkerName.ResetText();
            rtbTaskDescription.Text = "";
            cbWorker.Text = "";

            MessageBox.Show("Record updated");
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
