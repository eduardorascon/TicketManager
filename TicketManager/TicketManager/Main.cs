﻿using System;
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

            displayAllWorkers();
            displayEnabledWorkers();

            tbWorkerName.Text = "";

            MessageBox.Show("Registro agregado");
        }

        //update datagridview customer database
        public void displayAllWorkers()
        {
            Worker w = new Worker();
            dgvCustomerDB.DataSource = w.getAllWorkers();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            displayOpenTasks();
            displayClosedTasks();
            displayEnabledWorkers();
            displayAllWorkers();
            displayUsers();

            updateGraphs();
        }

        private void updateGraphs()
        {
            Graph g = new Graph();
            int total = g.getTotalTasksNumber();
            int active = g.getActiveTasksNumber();
            int closed = g.getClosedTasksNumber();

            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = total;
            circularProgressBar1.Value = active;
            circularProgressBar1.Text = active + " de" + total;

            circularProgressBar2.Minimum = 0;
            circularProgressBar2.Maximum = total;
            circularProgressBar2.Value = closed;
            circularProgressBar2.Text = closed + " de " + total;
        }

        private void displayEnabledWorkers()
        {
            Worker w = new Worker();
            cbWorker.DataSource = w.getAllEnabledWorkers();
            cbWorker.DisplayMember = "workerName";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Task t = new Task();

            int workerId = Worker.searchByName(cbWorker.Text);
            bool result = t.saveTask(tbTaskName.Text, tbTaskDescription.Text, mcTaskDateRange.SelectionStart, mcTaskDateRange.SelectionEnd, workerId);

            displayOpenTasks();

            tbTaskName.Text = "";
            tbWorkerName.ResetText();
            tbTaskDescription.Text = "";

            updateGraphs();

            MessageBox.Show("Registro agregado");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            int rowindex = dgvLiveTickets.CurrentCell.RowIndex;
            int taskToClose = int.Parse(dgvLiveTickets.Rows[rowindex].Cells[0].Value.ToString());

            closeTask(taskToClose);
            displayOpenTasks();
            displayClosedTasks();

            updateGraphs();
        }

        private void btnDeleteLive_Click(object sender, EventArgs e)
        {
            int rowindex = dgvLiveTickets.CurrentCell.RowIndex;
            int taskToDelete = int.Parse(dgvLiveTickets.Rows[rowindex].Cells[0].Value.ToString());

            deleteTask(taskToDelete);
            displayOpenTasks();
        }

        private void displayOpenTasks()
        {
            Task t = new Task();
            dgvLiveTickets.DataSource = t.getAllActiveTasks();
        }

        private void displayClosedTasks()
        {
            Task t = new Task();
            dgvClosedTickets.DataSource = t.getAllClosedTasks();
        }

        private void displayUsers()
        {
            UserLogin u = new UserLogin();
            dgvUsuarios.DataSource = u.getAllUsernames();
        }

        private void closeTask(int taskToClose)
        {
            Task t = new Task();
            t.closeTask(taskToClose);
        }

        private void deleteTask(int taskToDelete)
        {
            Task t = new Task();
            t.deleteTask(taskToDelete);
        }

        private void updateWorkerStatus(int workerToUpdate, bool status)
        {
            Worker w = new Worker();
            w.updateWorker(workerToUpdate, status);
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
            worksheet.Name = "Exportación";

            for (int i = 1; i < dgvClosedTickets.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvClosedTickets.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgvClosedTickets.Rows.Count; i++)
            {
                for (int j = 0; j < dgvClosedTickets.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvClosedTickets.Rows[i].Cells[j].Value.ToString();
                }
            }

            workbook.SaveAs("c:\\TareasCerradas.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);
        }

        private void dgvCustomerDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dgvCustomerDB.CurrentCell.RowIndex;
            int colindex = dgvCustomerDB.CurrentCell.ColumnIndex;

            int workerToUpdate = int.Parse(dgvCustomerDB.Rows[rowindex].Cells[0].Value.ToString());
            bool status = (bool)dgvCustomerDB.Rows[rowindex].Cells[2].Value;
            updateWorkerStatus(workerToUpdate, status);

            displayAllWorkers();
            displayEnabledWorkers();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //open excel and transfer data from datagridview
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet
                worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exportación";

            for (int i = 1; i < dgvLiveTickets.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvLiveTickets.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgvLiveTickets.Rows.Count; i++)
            {
                for (int j = 0; j < dgvLiveTickets.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvLiveTickets.Rows[i].Cells[j].Value.ToString();
                }
            }

            workbook.SaveAs("c:\\TareasAbiertas.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            UserLogin u = new UserLogin();

            bool result = u.saveUser(tbUsuario.Text, tbPass.Text);

            displayUsers();

            tbUsuario.Text = "";
            tbPass.Text = "";

            MessageBox.Show("Registro agregado");
        }
    }
}
