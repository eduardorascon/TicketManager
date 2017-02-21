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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvLiveTickets = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbEstimate = new System.Windows.Forms.TextBox();
            this.tbPhoneNo = new System.Windows.Forms.TextBox();
            this.tbPostcode = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbClient = new System.Windows.Forms.TextBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.cbTech = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDeleteLive = new System.Windows.Forms.Button();
            this.LogOut1 = new System.Windows.Forms.Button();
            this.dgvClosedTickets = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnDeleteClosed = new System.Windows.Forms.Button();
            this.dgvCustomerDB = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.tbClientPostcode = new System.Windows.Forms.TextBox();
            this.tbClientPhone = new System.Windows.Forms.TextBox();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.tbClientAddress = new System.Windows.Forms.TextBox();
            this.tbClientEmail = new System.Windows.Forms.TextBox();
            this.tbClientWebsite = new System.Windows.Forms.TextBox();
            this.tbClientID = new System.Windows.Forms.TextBox();
            this.btnSaveClient = new System.Windows.Forms.Button();
            this.ticketManagerDataSet1 = new TicketManager.TicketManagerDataSet1();
            this.customerDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDBTableAdapter = new TicketManager.TicketManagerDataSet1TableAdapters.customerDBTableAdapter();
            this.ticketManagerDataSet2 = new TicketManager.TicketManagerDataSet2();
            this.techsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techsTableAdapter = new TicketManager.TicketManagerDataSet2TableAdapters.techsTableAdapter();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estimate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TechName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiveTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClosedTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketManagerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketManagerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1496, 758);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.LogOut1);
            this.tabPage1.Controls.Add(this.btnDeleteLive);
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.cbTech);
            this.tabPage1.Controls.Add(this.rtbDescription);
            this.tabPage1.Controls.Add(this.tbClient);
            this.tabPage1.Controls.Add(this.tbAddress);
            this.tabPage1.Controls.Add(this.tbPostcode);
            this.tabPage1.Controls.Add(this.tbPhoneNo);
            this.tabPage1.Controls.Add(this.tbEstimate);
            this.tabPage1.Controls.Add(this.tbID);
            this.tabPage1.Controls.Add(this.monthCalendar1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvLiveTickets);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1488, 732);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Live Tickets";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btnDeleteClosed);
            this.tabPage2.Controls.Add(this.btnExcel);
            this.tabPage2.Controls.Add(this.tbTotal);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.dgvClosedTickets);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1488, 732);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Closed Tickets";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.btnSaveClient);
            this.tabPage3.Controls.Add(this.tbClientID);
            this.tabPage3.Controls.Add(this.tbClientWebsite);
            this.tabPage3.Controls.Add(this.tbClientEmail);
            this.tabPage3.Controls.Add(this.tbClientAddress);
            this.tabPage3.Controls.Add(this.tbClientName);
            this.tabPage3.Controls.Add(this.tbClientPhone);
            this.tabPage3.Controls.Add(this.tbClientPostcode);
            this.tabPage3.Controls.Add(this.tbContact);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.dgvCustomerDB);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1488, 732);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Customer Database";
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
            this.dgvLiveTickets.Location = new System.Drawing.Point(26, 50);
            this.dgvLiveTickets.Name = "dgvLiveTickets";
            this.dgvLiveTickets.Size = new System.Drawing.Size(925, 608);
            this.dgvLiveTickets.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Live Tickets";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1026, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date Due";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1014, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1078, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1057, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1048, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Postcode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1033, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Phone No.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1029, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Technician";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(968, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1078, 665);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "Estimate";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1132, 50);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(1053, 181);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(67, 31);
            this.tbID.TabIndex = 1;
            // 
            // tbEstimate
            // 
            this.tbEstimate.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEstimate.Location = new System.Drawing.Point(972, 661);
            this.tbEstimate.Name = "tbEstimate";
            this.tbEstimate.Size = new System.Drawing.Size(100, 31);
            this.tbEstimate.TabIndex = 8;
            // 
            // tbPhoneNo
            // 
            this.tbPhoneNo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNo.Location = new System.Drawing.Point(1143, 359);
            this.tbPhoneNo.Name = "tbPhoneNo";
            this.tbPhoneNo.Size = new System.Drawing.Size(216, 31);
            this.tbPhoneNo.TabIndex = 5;
            // 
            // tbPostcode
            // 
            this.tbPostcode.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostcode.Location = new System.Drawing.Point(1143, 322);
            this.tbPostcode.Name = "tbPostcode";
            this.tbPostcode.Size = new System.Drawing.Size(216, 31);
            this.tbPostcode.TabIndex = 4;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(1143, 285);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(216, 31);
            this.tbAddress.TabIndex = 3;
            // 
            // tbClient
            // 
            this.tbClient.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClient.Location = new System.Drawing.Point(1143, 248);
            this.tbClient.Name = "tbClient";
            this.tbClient.Size = new System.Drawing.Size(216, 31);
            this.tbClient.TabIndex = 2;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.Location = new System.Drawing.Point(972, 478);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(392, 153);
            this.rtbDescription.TabIndex = 7;
            this.rtbDescription.Text = "";
            // 
            // cbTech
            // 
            this.cbTech.DataSource = this.techsBindingSource;
            this.cbTech.DisplayMember = "techName";
            this.cbTech.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTech.FormattingEnabled = true;
            this.cbTech.Location = new System.Drawing.Point(1143, 396);
            this.cbTech.Name = "cbTech";
            this.cbTech.Size = new System.Drawing.Size(216, 31);
            this.cbTech.TabIndex = 6;
            this.cbTech.ValueMember = "techName";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1192, 652);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 52);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1281, 652);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 52);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(685, 661);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 52);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close Ticket";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDeleteLive
            // 
            this.btnDeleteLive.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLive.Location = new System.Drawing.Point(818, 661);
            this.btnDeleteLive.Name = "btnDeleteLive";
            this.btnDeleteLive.Size = new System.Drawing.Size(133, 52);
            this.btnDeleteLive.TabIndex = 23;
            this.btnDeleteLive.Text = "Delete Ticket";
            this.btnDeleteLive.UseVisualStyleBackColor = true;
            this.btnDeleteLive.Click += new System.EventHandler(this.btnDeleteLive_Click);
            // 
            // LogOut1
            // 
            this.LogOut1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut1.Location = new System.Drawing.Point(1289, 0);
            this.LogOut1.Name = "LogOut1";
            this.LogOut1.Size = new System.Drawing.Size(75, 23);
            this.LogOut1.TabIndex = 24;
            this.LogOut1.Text = "Log Out";
            this.LogOut1.UseVisualStyleBackColor = true;
            this.LogOut1.Click += new System.EventHandler(this.LogOut1_Click);
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
            this.dgvClosedTickets.Location = new System.Drawing.Point(24, 52);
            this.dgvClosedTickets.Name = "dgvClosedTickets";
            this.dgvClosedTickets.Size = new System.Drawing.Size(1084, 636);
            this.dgvClosedTickets.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "Closed Tickets";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1165, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 23);
            this.label12.TabIndex = 2;
            this.label12.Text = "Total Invoiced:";
            // 
            // tbTotal
            // 
            this.tbTotal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(1169, 78);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(152, 31);
            this.tbTotal.TabIndex = 3;
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcel.Location = new System.Drawing.Point(1169, 318);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(168, 86);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnDeleteClosed
            // 
            this.btnDeleteClosed.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClosed.Location = new System.Drawing.Point(1169, 602);
            this.btnDeleteClosed.Name = "btnDeleteClosed";
            this.btnDeleteClosed.Size = new System.Drawing.Size(168, 86);
            this.btnDeleteClosed.TabIndex = 5;
            this.btnDeleteClosed.Text = "Delete";
            this.btnDeleteClosed.UseVisualStyleBackColor = true;
            this.btnDeleteClosed.Click += new System.EventHandler(this.btnDeleteClosed_Click);
            // 
            // dgvCustomerDB
            // 
            this.dgvCustomerDB.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvCustomerDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerDB.Location = new System.Drawing.Point(24, 53);
            this.dgvCustomerDB.Name = "dgvCustomerDB";
            this.dgvCustomerDB.Size = new System.Drawing.Size(847, 634);
            this.dgvCustomerDB.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(196, 23);
            this.label13.TabIndex = 1;
            this.label13.Text = "Customer Database";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(950, 492);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 23);
            this.label14.TabIndex = 2;
            this.label14.Text = "Website";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(973, 455);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 23);
            this.label15.TabIndex = 3;
            this.label15.Text = "Email";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(968, 416);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 23);
            this.label16.TabIndex = 4;
            this.label16.Text = "Phone";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(941, 381);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 23);
            this.label17.TabIndex = 5;
            this.label17.Text = "Postcode";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(950, 344);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 23);
            this.label18.TabIndex = 6;
            this.label18.Text = "Address";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(947, 307);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 23);
            this.label19.TabIndex = 7;
            this.label19.Text = "Contact";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(964, 270);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 23);
            this.label20.TabIndex = 8;
            this.label20.Text = "Client";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(1169, 228);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 23);
            this.label21.TabIndex = 9;
            this.label21.Text = "ID";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(1074, 158);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(197, 23);
            this.label22.TabIndex = 10;
            this.label22.Text = "Add new customer:";
            // 
            // tbContact
            // 
            this.tbContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContact.Location = new System.Drawing.Point(1035, 304);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(266, 29);
            this.tbContact.TabIndex = 11;
            // 
            // tbClientPostcode
            // 
            this.tbClientPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientPostcode.Location = new System.Drawing.Point(1035, 378);
            this.tbClientPostcode.Name = "tbClientPostcode";
            this.tbClientPostcode.Size = new System.Drawing.Size(266, 29);
            this.tbClientPostcode.TabIndex = 12;
            // 
            // tbClientPhone
            // 
            this.tbClientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientPhone.Location = new System.Drawing.Point(1035, 413);
            this.tbClientPhone.Name = "tbClientPhone";
            this.tbClientPhone.Size = new System.Drawing.Size(266, 29);
            this.tbClientPhone.TabIndex = 13;
            // 
            // tbClientName
            // 
            this.tbClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientName.Location = new System.Drawing.Point(1035, 267);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(266, 29);
            this.tbClientName.TabIndex = 14;
            // 
            // tbClientAddress
            // 
            this.tbClientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientAddress.Location = new System.Drawing.Point(1035, 341);
            this.tbClientAddress.Name = "tbClientAddress";
            this.tbClientAddress.Size = new System.Drawing.Size(266, 29);
            this.tbClientAddress.TabIndex = 15;
            // 
            // tbClientEmail
            // 
            this.tbClientEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientEmail.Location = new System.Drawing.Point(1035, 452);
            this.tbClientEmail.Name = "tbClientEmail";
            this.tbClientEmail.Size = new System.Drawing.Size(266, 29);
            this.tbClientEmail.TabIndex = 16;
            // 
            // tbClientWebsite
            // 
            this.tbClientWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientWebsite.Location = new System.Drawing.Point(1035, 489);
            this.tbClientWebsite.Name = "tbClientWebsite";
            this.tbClientWebsite.Size = new System.Drawing.Size(266, 29);
            this.tbClientWebsite.TabIndex = 17;
            // 
            // tbClientID
            // 
            this.tbClientID.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientID.Location = new System.Drawing.Point(1222, 225);
            this.tbClientID.Name = "tbClientID";
            this.tbClientID.Size = new System.Drawing.Size(79, 31);
            this.tbClientID.TabIndex = 18;
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.Location = new System.Drawing.Point(1226, 544);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(75, 23);
            this.btnSaveClient.TabIndex = 19;
            this.btnSaveClient.Text = "Save";
            this.btnSaveClient.UseVisualStyleBackColor = true;
            this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click);
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
            // ticketManagerDataSet2
            // 
            this.ticketManagerDataSet2.DataSetName = "TicketManagerDataSet2";
            this.ticketManagerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // techsBindingSource
            // 
            this.techsBindingSource.DataMember = "techs";
            this.techsBindingSource.DataSource = this.ticketManagerDataSet2;
            // 
            // techsTableAdapter
            // 
            this.techsTableAdapter.ClearBeforeFill = true;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1292, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1292, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1379, 747);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiveTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClosedTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketManagerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketManagerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvLiveTickets;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogOut1;
        private System.Windows.Forms.Button btnDeleteLive;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbTech;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.TextBox tbClient;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPostcode;
        private System.Windows.Forms.TextBox tbPhoneNo;
        private System.Windows.Forms.TextBox tbEstimate;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnDeleteClosed;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvClosedTickets;
        private System.Windows.Forms.Button btnSaveClient;
        private System.Windows.Forms.TextBox tbClientID;
        private System.Windows.Forms.TextBox tbClientWebsite;
        private System.Windows.Forms.TextBox tbClientEmail;
        private System.Windows.Forms.TextBox tbClientAddress;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.TextBox tbClientPhone;
        private System.Windows.Forms.TextBox tbClientPostcode;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}