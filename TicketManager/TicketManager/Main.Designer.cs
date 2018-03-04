﻿namespace TicketManager
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteLive = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbWorker = new System.Windows.Forms.ComboBox();
            this.rtbTaskDescription = new System.Windows.Forms.RichTextBox();
            this.tbTaskName = new System.Windows.Forms.TextBox();
            this.mcTaskDateRange = new System.Windows.Forms.MonthCalendar();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLiveTickets = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExcel = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvClosedTickets = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSaveClient = new System.Windows.Forms.Button();
            this.tbWorkerName = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvCustomerDB = new System.Windows.Forms.DataGridView();
            this.ticketManagerDataSet2 = new TicketManager.TicketManagerDataSet2();
            this.ticketManagerDataSet1 = new TicketManager.TicketManagerDataSet1();
            this.customerDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDBTableAdapter = new TicketManager.TicketManagerDataSet1TableAdapters.customerDBTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiveTickets)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClosedTickets)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketManagerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketManagerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-5, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1995, 933);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnDeleteLive);
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.cbWorker);
            this.tabPage1.Controls.Add(this.rtbTaskDescription);
            this.tabPage1.Controls.Add(this.tbTaskName);
            this.tabPage1.Controls.Add(this.mcTaskDateRange);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvLiveTickets);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1987, 904);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Live Tickets";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(807, 384);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Descripción";
            // 
            // btnDeleteLive
            // 
            this.btnDeleteLive.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLive.Location = new System.Drawing.Point(588, 557);
            this.btnDeleteLive.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteLive.Name = "btnDeleteLive";
            this.btnDeleteLive.Size = new System.Drawing.Size(177, 64);
            this.btnDeleteLive.TabIndex = 23;
            this.btnDeleteLive.Text = "Delete Ticket";
            this.btnDeleteLive.UseVisualStyleBackColor = true;
            this.btnDeleteLive.Click += new System.EventHandler(this.btnDeleteLive_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(410, 557);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(169, 64);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close Ticket";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1254, 557);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 64);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbWorker
            // 
            this.cbWorker.DisplayMember = "techName";
            this.cbWorker.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWorker.FormattingEnabled = true;
            this.cbWorker.Location = new System.Drawing.Point(956, 333);
            this.cbWorker.Margin = new System.Windows.Forms.Padding(4);
            this.cbWorker.Name = "cbWorker";
            this.cbWorker.Size = new System.Drawing.Size(409, 37);
            this.cbWorker.TabIndex = 6;
            this.cbWorker.ValueMember = "techName";
            // 
            // rtbTaskDescription
            // 
            this.rtbTaskDescription.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTaskDescription.Location = new System.Drawing.Point(817, 426);
            this.rtbTaskDescription.Margin = new System.Windows.Forms.Padding(4);
            this.rtbTaskDescription.Name = "rtbTaskDescription";
            this.rtbTaskDescription.Size = new System.Drawing.Size(548, 123);
            this.rtbTaskDescription.TabIndex = 7;
            this.rtbTaskDescription.Text = "";
            // 
            // tbTaskName
            // 
            this.tbTaskName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaskName.Location = new System.Drawing.Point(956, 289);
            this.tbTaskName.Margin = new System.Windows.Forms.Padding(4);
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.Size = new System.Drawing.Size(409, 36);
            this.tbTaskName.TabIndex = 2;
            // 
            // mcTaskDateRange
            // 
            this.mcTaskDateRange.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.mcTaskDateRange.Location = new System.Drawing.Point(795, 62);
            this.mcTaskDateRange.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.mcTaskDateRange.MaxSelectionCount = 10000;
            this.mcTaskDateRange.Name = "mcTaskDateRange";
            this.mcTaskDateRange.ShowToday = false;
            this.mcTaskDateRange.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(807, 336);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 29);
            this.label8.TabIndex = 8;
            this.label8.Text = "Trabajador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(812, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tarea";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tareas pendientes";
            // 
            // dgvLiveTickets
            // 
            this.dgvLiveTickets.AllowUserToAddRows = false;
            this.dgvLiveTickets.AllowUserToDeleteRows = false;
            this.dgvLiveTickets.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvLiveTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLiveTickets.Location = new System.Drawing.Point(35, 62);
            this.dgvLiveTickets.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLiveTickets.Name = "dgvLiveTickets";
            this.dgvLiveTickets.ReadOnly = true;
            this.dgvLiveTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLiveTickets.Size = new System.Drawing.Size(730, 487);
            this.dgvLiveTickets.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage2.Controls.Add(this.btnExcel);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.dgvClosedTickets);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1987, 904);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Closed Tickets";
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcel.Location = new System.Drawing.Point(1195, 63);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(224, 106);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 29);
            this.label11.TabIndex = 1;
            this.label11.Text = "Closed Tickets";
            // 
            // dgvClosedTickets
            // 
            this.dgvClosedTickets.AllowUserToAddRows = false;
            this.dgvClosedTickets.AllowUserToDeleteRows = false;
            this.dgvClosedTickets.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvClosedTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClosedTickets.Location = new System.Drawing.Point(30, 63);
            this.dgvClosedTickets.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClosedTickets.Name = "dgvClosedTickets";
            this.dgvClosedTickets.ReadOnly = true;
            this.dgvClosedTickets.Size = new System.Drawing.Size(1127, 507);
            this.dgvClosedTickets.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage3.Controls.Add(this.btnSaveClient);
            this.tabPage3.Controls.Add(this.tbWorkerName);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.dgvCustomerDB);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1987, 904);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Customer Database";
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClient.Location = new System.Drawing.Point(1161, 185);
            this.btnSaveClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(141, 55);
            this.btnSaveClient.TabIndex = 19;
            this.btnSaveClient.Text = "Save";
            this.btnSaveClient.UseVisualStyleBackColor = true;
            this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click);
            // 
            // tbWorkerName
            // 
            this.tbWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWorkerName.Location = new System.Drawing.Point(949, 143);
            this.tbWorkerName.Margin = new System.Windows.Forms.Padding(4);
            this.tbWorkerName.Name = "tbWorkerName";
            this.tbWorkerName.Size = new System.Drawing.Size(353, 34);
            this.tbWorkerName.TabIndex = 14;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(944, 65);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(232, 29);
            this.label22.TabIndex = 10;
            this.label22.Text = "Nuevo trabajador:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(944, 110);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(108, 29);
            this.label20.TabIndex = 8;
            this.label20.Text = "Nombre";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(27, 33);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(294, 29);
            this.label13.TabIndex = 1;
            this.label13.Text = "Listado de trabajadores";
            // 
            // dgvCustomerDB
            // 
            this.dgvCustomerDB.AllowUserToAddRows = false;
            this.dgvCustomerDB.AllowUserToDeleteRows = false;
            this.dgvCustomerDB.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvCustomerDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerDB.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCustomerDB.Location = new System.Drawing.Point(32, 65);
            this.dgvCustomerDB.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCustomerDB.Name = "dgvCustomerDB";
            this.dgvCustomerDB.ReadOnly = true;
            this.dgvCustomerDB.Size = new System.Drawing.Size(885, 389);
            this.dgvCustomerDB.TabIndex = 0;
            this.dgvCustomerDB.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCustomerDB_DataBindingComplete);
            // 
            // ticketManagerDataSet2
            // 
            this.ticketManagerDataSet2.DataSetName = "TicketManagerDataSet2";
            this.ticketManagerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketManagerDataSet1
            // 
            this.ticketManagerDataSet1.DataSetName = "TicketManagerDataSet1";
            this.ticketManagerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerDBBindingSource
            // 
            this.customerDBBindingSource.DataMember = "customerDB";
            this.customerDBBindingSource.DataSource = this.ticketManagerDataSet1;
            // 
            // customerDBTableAdapter
            // 
            this.customerDBTableAdapter.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1499, 659);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiveTickets)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClosedTickets)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketManagerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketManagerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDBBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvLiveTickets;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteLive;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbWorker;
        private System.Windows.Forms.RichTextBox rtbTaskDescription;
        private System.Windows.Forms.TextBox tbTaskName;
        private System.Windows.Forms.MonthCalendar mcTaskDateRange;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvClosedTickets;
        private System.Windows.Forms.Button btnSaveClient;
        private System.Windows.Forms.TextBox tbWorkerName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvCustomerDB;
        private TicketManagerDataSet1 ticketManagerDataSet1;
        private System.Windows.Forms.BindingSource customerDBBindingSource;
        private TicketManagerDataSet1TableAdapters.customerDBTableAdapter customerDBTableAdapter;
        private TicketManagerDataSet2 ticketManagerDataSet2;
        private System.Windows.Forms.Label label2;
    }
}