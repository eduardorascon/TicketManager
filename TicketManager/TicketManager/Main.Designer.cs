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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteLive = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbWorker = new System.Windows.Forms.ComboBox();
            this.tbTaskName = new System.Windows.Forms.TextBox();
            this.mcTaskDateRange = new System.Windows.Forms.MonthCalendar();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvLiveTickets = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExcel = new System.Windows.Forms.Button();
            this.dgvClosedTickets = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSaveClient = new System.Windows.Forms.Button();
            this.tbWorkerName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dgvCustomerDB = new System.Windows.Forms.DataGridView();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tbTaskDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.circularProgressBar2 = new CircularProgressBar.CircularProgressBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiveTickets)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClosedTickets)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
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
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbTaskDescription);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnDeleteLive);
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.cbWorker);
            this.tabPage1.Controls.Add(this.tbTaskName);
            this.tabPage1.Controls.Add(this.mcTaskDateRange);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dgvLiveTickets);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1987, 904);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tareas abiertas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(778, 357);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Descripción";
            // 
            // btnDeleteLive
            // 
            this.btnDeleteLive.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLive.Location = new System.Drawing.Point(960, 522);
            this.btnDeleteLive.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteLive.Name = "btnDeleteLive";
            this.btnDeleteLive.Size = new System.Drawing.Size(177, 64);
            this.btnDeleteLive.TabIndex = 23;
            this.btnDeleteLive.Text = "Eliminar tarea";
            this.btnDeleteLive.UseVisualStyleBackColor = true;
            this.btnDeleteLive.Click += new System.EventHandler(this.btnDeleteLive_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(783, 523);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(169, 64);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Cerrar tarea";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1183, 523);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 64);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Guardar tarea";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbWorker
            // 
            this.cbWorker.DisplayMember = "techName";
            this.cbWorker.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWorker.FormattingEnabled = true;
            this.cbWorker.Location = new System.Drawing.Point(944, 306);
            this.cbWorker.Margin = new System.Windows.Forms.Padding(4);
            this.cbWorker.Name = "cbWorker";
            this.cbWorker.Size = new System.Drawing.Size(409, 37);
            this.cbWorker.TabIndex = 6;
            this.cbWorker.ValueMember = "techName";
            // 
            // tbTaskName
            // 
            this.tbTaskName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaskName.Location = new System.Drawing.Point(944, 262);
            this.tbTaskName.Margin = new System.Windows.Forms.Padding(4);
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.Size = new System.Drawing.Size(409, 36);
            this.tbTaskName.TabIndex = 2;
            // 
            // mcTaskDateRange
            // 
            this.mcTaskDateRange.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.mcTaskDateRange.Location = new System.Drawing.Point(778, 48);
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
            this.label8.Location = new System.Drawing.Point(777, 309);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 29);
            this.label8.TabIndex = 8;
            this.label8.Text = "Colaborador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(778, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tarea";
            // 
            // dgvLiveTickets
            // 
            this.dgvLiveTickets.AllowUserToAddRows = false;
            this.dgvLiveTickets.AllowUserToDeleteRows = false;
            this.dgvLiveTickets.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvLiveTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLiveTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificador,
            this.taskName,
            this.taskDescription,
            this.FechaInicio,
            this.FechaFin,
            this.taskDuration,
            this.workerName});
            this.dgvLiveTickets.Location = new System.Drawing.Point(14, 8);
            this.dgvLiveTickets.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLiveTickets.Name = "dgvLiveTickets";
            this.dgvLiveTickets.ReadOnly = true;
            this.dgvLiveTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLiveTickets.Size = new System.Drawing.Size(751, 362);
            this.dgvLiveTickets.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.btnExcel);
            this.tabPage2.Controls.Add(this.dgvClosedTickets);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1987, 904);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tareas cerradas";
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcel.Location = new System.Drawing.Point(773, 8);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(224, 106);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // dgvClosedTickets
            // 
            this.dgvClosedTickets.AllowUserToAddRows = false;
            this.dgvClosedTickets.AllowUserToDeleteRows = false;
            this.dgvClosedTickets.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvClosedTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClosedTickets.Location = new System.Drawing.Point(14, 8);
            this.dgvClosedTickets.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClosedTickets.Name = "dgvClosedTickets";
            this.dgvClosedTickets.ReadOnly = true;
            this.dgvClosedTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClosedTickets.Size = new System.Drawing.Size(751, 362);
            this.dgvClosedTickets.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.btnSaveClient);
            this.tabPage3.Controls.Add(this.tbWorkerName);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.dgvCustomerDB);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1987, 904);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Colaboradores";
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClient.Location = new System.Drawing.Point(1020, 83);
            this.btnSaveClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(163, 55);
            this.btnSaveClient.TabIndex = 19;
            this.btnSaveClient.Text = "Guardar";
            this.btnSaveClient.UseVisualStyleBackColor = true;
            this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click);
            // 
            // tbWorkerName
            // 
            this.tbWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWorkerName.Location = new System.Drawing.Point(778, 41);
            this.tbWorkerName.Margin = new System.Windows.Forms.Padding(4);
            this.tbWorkerName.Name = "tbWorkerName";
            this.tbWorkerName.Size = new System.Drawing.Size(405, 34);
            this.tbWorkerName.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(773, 8);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(295, 29);
            this.label20.TabIndex = 8;
            this.label20.Text = "Nombre de colaborador";
            // 
            // dgvCustomerDB
            // 
            this.dgvCustomerDB.AllowUserToAddRows = false;
            this.dgvCustomerDB.AllowUserToDeleteRows = false;
            this.dgvCustomerDB.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvCustomerDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.workerName2,
            this.workerIsActive});
            this.dgvCustomerDB.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCustomerDB.Location = new System.Drawing.Point(14, 8);
            this.dgvCustomerDB.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCustomerDB.Name = "dgvCustomerDB";
            this.dgvCustomerDB.ReadOnly = true;
            this.dgvCustomerDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerDB.Size = new System.Drawing.Size(751, 362);
            this.dgvCustomerDB.TabIndex = 0;
            this.dgvCustomerDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerDB_CellContentClick);
            // 
            // Identificador
            // 
            this.Identificador.DataPropertyName = "Id";
            this.Identificador.HeaderText = "Identificador";
            this.Identificador.Name = "Identificador";
            this.Identificador.ReadOnly = true;
            // 
            // taskName
            // 
            this.taskName.DataPropertyName = "taskName";
            this.taskName.HeaderText = "Tarea";
            this.taskName.Name = "taskName";
            this.taskName.ReadOnly = true;
            // 
            // taskDescription
            // 
            this.taskDescription.DataPropertyName = "taskDescription";
            this.taskDescription.HeaderText = "Descripción";
            this.taskDescription.Name = "taskDescription";
            this.taskDescription.ReadOnly = true;
            // 
            // FechaInicio
            // 
            this.FechaInicio.DataPropertyName = "taskStartDate";
            this.FechaInicio.HeaderText = "Fecha inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // FechaFin
            // 
            this.FechaFin.DataPropertyName = "taskEndDate";
            this.FechaFin.HeaderText = "Fecha final";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            // 
            // taskDuration
            // 
            this.taskDuration.DataPropertyName = "taskDuration";
            this.taskDuration.HeaderText = "Duración estimada";
            this.taskDuration.Name = "taskDuration";
            this.taskDuration.ReadOnly = true;
            // 
            // workerName
            // 
            this.workerName.DataPropertyName = "workerName";
            this.workerName.HeaderText = "Colaborador";
            this.workerName.Name = "workerName";
            this.workerName.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Identificador";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // workerName2
            // 
            this.workerName2.DataPropertyName = "workerName";
            this.workerName2.HeaderText = "Colaborador";
            this.workerName2.Name = "workerName2";
            this.workerName2.ReadOnly = true;
            // 
            // workerIsActive
            // 
            this.workerIsActive.DataPropertyName = "workerIsEnabled";
            this.workerIsActive.HeaderText = "Colaborador habilitado/deshabilitado";
            this.workerIsActive.Name = "workerIsActive";
            this.workerIsActive.ReadOnly = true;
            this.workerIsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.workerIsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.workerIsActive.Width = 200;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 523);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 523);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(14, 523);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(300, 99);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // tbTaskDescription
            // 
            this.tbTaskDescription.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaskDescription.Location = new System.Drawing.Point(783, 390);
            this.tbTaskDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbTaskDescription.Multiline = true;
            this.tbTaskDescription.Name = "tbTaskDescription";
            this.tbTaskDescription.Size = new System.Drawing.Size(570, 124);
            this.tbTaskDescription.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(773, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Fecha";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.circularProgressBar2);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.circularProgressBar1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1987, 904);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Estadísticas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Arial Narrow", 22F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.White;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(242, 96);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.LightGray;
            this.circularProgressBar1.OuterMargin = -50;
            this.circularProgressBar1.OuterWidth = 50;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.CornflowerBlue;
            this.circularProgressBar1.ProgressWidth = 40;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(327, 320);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 0;
            this.circularProgressBar1.Text = "3";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.circularProgressBar1.Value = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(800, 438);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tareas cerradas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(304, 438);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tareas abiertas";
            // 
            // circularProgressBar2
            // 
            this.circularProgressBar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar2.AnimationSpeed = 500;
            this.circularProgressBar2.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar2.Font = new System.Drawing.Font("Arial Narrow", 22F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar2.InnerColor = System.Drawing.Color.White;
            this.circularProgressBar2.InnerMargin = 2;
            this.circularProgressBar2.InnerWidth = -1;
            this.circularProgressBar2.Location = new System.Drawing.Point(735, 96);
            this.circularProgressBar2.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar2.Name = "circularProgressBar2";
            this.circularProgressBar2.OuterColor = System.Drawing.Color.LightGray;
            this.circularProgressBar2.OuterMargin = -50;
            this.circularProgressBar2.OuterWidth = 50;
            this.circularProgressBar2.ProgressColor = System.Drawing.Color.CornflowerBlue;
            this.circularProgressBar2.ProgressWidth = 40;
            this.circularProgressBar2.RightToLeftLayout = true;
            this.circularProgressBar2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar2.Size = new System.Drawing.Size(320, 320);
            this.circularProgressBar2.StartAngle = 270;
            this.circularProgressBar2.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar2.SubscriptText = "";
            this.circularProgressBar2.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar2.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar2.SuperscriptText = "";
            this.circularProgressBar2.TabIndex = 11;
            this.circularProgressBar2.Text = "3";
            this.circularProgressBar2.TextMargin = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.circularProgressBar2.Value = 50;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1499, 659);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiveTickets)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClosedTickets)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
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
        private System.Windows.Forms.Button btnDeleteLive;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbWorker;
        private System.Windows.Forms.TextBox tbTaskName;
        private System.Windows.Forms.MonthCalendar mcTaskDateRange;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridView dgvClosedTickets;
        private System.Windows.Forms.Button btnSaveClient;
        private System.Windows.Forms.TextBox tbWorkerName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgvCustomerDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerName2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn workerIsActive;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTaskDescription;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private CircularProgressBar.CircularProgressBar circularProgressBar2;
    }
}