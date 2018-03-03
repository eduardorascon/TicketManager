namespace TicketManager
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
            this.btnDeleteLive = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbTech = new System.Windows.Forms.ComboBox();
            this.techsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketManagerDataSet2 = new TicketManager.TicketManagerDataSet2();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.tbClient = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLiveTickets = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estimate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExcel = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvClosedTickets = new System.Windows.Forms.DataGridView();
            this.CustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TechName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSaveClient = new System.Windows.Forms.Button();
            this.tbWorkerName = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvCustomerDB = new System.Windows.Forms.DataGridView();
            this.ticketManagerDataSet1 = new TicketManager.TicketManagerDataSet1();
            this.customerDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDBTableAdapter = new TicketManager.TicketManagerDataSet1TableAdapters.customerDBTableAdapter();
            this.techsTableAdapter = new TicketManager.TicketManagerDataSet2TableAdapters.techsTableAdapter();
            this.btnEnableWorker = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.techsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketManagerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiveTickets)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClosedTickets)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDB)).BeginInit();
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1995, 933);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.btnDeleteLive);
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.cbTech);
            this.tabPage1.Controls.Add(this.rtbDescription);
            this.tabPage1.Controls.Add(this.tbClient);
            this.tabPage1.Controls.Add(this.monthCalendar1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvLiveTickets);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1987, 904);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Live Tickets";
            // 
            // btnDeleteLive
            // 
            this.btnDeleteLive.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLive.Location = new System.Drawing.Point(1042, 557);
            this.btnDeleteLive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnClose.Location = new System.Drawing.Point(864, 557);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnSave.Location = new System.Drawing.Point(984, 485);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 64);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(865, 485);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 64);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbTech
            // 
            this.cbTech.DataSource = this.techsBindingSource;
            this.cbTech.DisplayMember = "techName";
            this.cbTech.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTech.FormattingEnabled = true;
            this.cbTech.Location = new System.Drawing.Point(956, 356);
            this.cbTech.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTech.Name = "cbTech";
            this.cbTech.Size = new System.Drawing.Size(287, 37);
            this.cbTech.TabIndex = 6;
            this.cbTech.ValueMember = "techName";
            // 
            // techsBindingSource
            // 
            this.techsBindingSource.DataMember = "techs";
            this.techsBindingSource.DataSource = this.ticketManagerDataSet2;
            // 
            // ticketManagerDataSet2
            // 
            this.ticketManagerDataSet2.DataSetName = "TicketManagerDataSet2";
            this.ticketManagerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.Location = new System.Drawing.Point(1264, 289);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(311, 187);
            this.rtbDescription.TabIndex = 7;
            this.rtbDescription.Text = "";
            // 
            // tbClient
            // 
            this.tbClient.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClient.Location = new System.Drawing.Point(956, 312);
            this.tbClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbClient.Name = "tbClient";
            this.tbClient.Size = new System.Drawing.Size(287, 36);
            this.tbClient.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(801, 67);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1273, 187);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(812, 359);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 29);
            this.label8.TabIndex = 8;
            this.label8.Text = "Technician";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(868, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(796, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date Due";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Live Tickets";
            // 
            // dgvLiveTickets
            // 
            this.dgvLiveTickets.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvLiveTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLiveTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Client,
            this.Address,
            this.Postcode,
            this.Phone,
            this.Tech,
            this.Description,
            this.Estimate,
            this.DateDue});
            this.dgvLiveTickets.Location = new System.Drawing.Point(35, 62);
            this.dgvLiveTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLiveTickets.Name = "dgvLiveTickets";
            this.dgvLiveTickets.Size = new System.Drawing.Size(730, 487);
            this.dgvLiveTickets.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Client
            // 
            this.Client.HeaderText = "Client";
            this.Client.Name = "Client";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // Postcode
            // 
            this.Postcode.HeaderText = "Postcode";
            this.Postcode.Name = "Postcode";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // Tech
            // 
            this.Tech.HeaderText = "Tech";
            this.Tech.Name = "Tech";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Estimate
            // 
            this.Estimate.HeaderText = "Column1";
            this.Estimate.Name = "Estimate";
            this.Estimate.Visible = false;
            // 
            // DateDue
            // 
            this.DateDue.HeaderText = "Date Due";
            this.DateDue.Name = "DateDue";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage2.Controls.Add(this.btnExcel);
            this.tabPage2.Controls.Add(this.tbTotal);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.dgvClosedTickets);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1987, 904);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Closed Tickets";
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcel.Location = new System.Drawing.Point(1249, 201);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(224, 106);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(1272, 360);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(201, 36);
            this.tbTotal.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1266, 328);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 29);
            this.label12.TabIndex = 2;
            this.label12.Text = "Total Invoiced:";
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
            this.dgvClosedTickets.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvClosedTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClosedTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustID,
            this.ClientName,
            this.Add,
            this.Post,
            this.PhoneNo,
            this.TechName,
            this.Desc,
            this.Price,
            this.date});
            this.dgvClosedTickets.Location = new System.Drawing.Point(30, 63);
            this.dgvClosedTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvClosedTickets.Name = "dgvClosedTickets";
            this.dgvClosedTickets.Size = new System.Drawing.Size(1197, 437);
            this.dgvClosedTickets.TabIndex = 0;
            // 
            // CustID
            // 
            this.CustID.HeaderText = "ID";
            this.CustID.Name = "CustID";
            // 
            // ClientName
            // 
            this.ClientName.HeaderText = "Client";
            this.ClientName.Name = "ClientName";
            // 
            // Add
            // 
            this.Add.HeaderText = "Address";
            this.Add.Name = "Add";
            // 
            // Post
            // 
            this.Post.HeaderText = "Postcode";
            this.Post.Name = "Post";
            // 
            // PhoneNo
            // 
            this.PhoneNo.HeaderText = "Phone";
            this.PhoneNo.Name = "PhoneNo";
            // 
            // TechName
            // 
            this.TechName.HeaderText = "Tech";
            this.TechName.Name = "TechName";
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Description";
            this.Desc.Name = "Desc";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // date
            // 
            this.date.HeaderText = "Column1";
            this.date.Name = "date";
            this.date.Visible = false;
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
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(1987, 904);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Customer Database";
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClient.Location = new System.Drawing.Point(1161, 185);
            this.btnSaveClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.tbWorkerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dgvCustomerDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEnableWorker});
            this.dgvCustomerDB.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCustomerDB.Location = new System.Drawing.Point(32, 65);
            this.dgvCustomerDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCustomerDB.Name = "dgvCustomerDB";
            this.dgvCustomerDB.ReadOnly = true;
            this.dgvCustomerDB.Size = new System.Drawing.Size(885, 389);
            this.dgvCustomerDB.TabIndex = 0;
            this.dgvCustomerDB.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCustomerDB_DataBindingComplete);
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
            // techsTableAdapter
            // 
            this.techsTableAdapter.ClearBeforeFill = true;
            // 
            // btnEnableWorker
            // 
            this.btnEnableWorker.HeaderText = "Habilitar/Deshabilitar";
            this.btnEnableWorker.Name = "btnEnableWorker";
            this.btnEnableWorker.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1681, 659);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.techsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketManagerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiveTickets)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClosedTickets)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDB)).EndInit();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteLive;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbTech;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.TextBox tbClient;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label12;
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
        private System.Windows.Forms.BindingSource techsBindingSource;
        private TicketManagerDataSet2TableAdapters.techsTableAdapter techsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tech;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estimate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TechName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewButtonColumn btnEnableWorker;
    }
}