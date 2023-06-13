namespace projecttt
{
    partial class Form1
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
            System.Windows.Forms.Label numeLabel;
            System.Windows.Forms.Label prenumeLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnRezerva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmsCheckIn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.oraCheckinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpInceput = new System.Windows.Forms.DateTimePicker();
            this.cbCamere = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmsCheckOut = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.oraCheckoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpSfarsit = new System.Windows.Forms.DateTimePicker();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPretFinal = new System.Windows.Forms.TextBox();
            this.tbPretPeNoapte = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rezervariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeRezervareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizarePerioadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perioadeOcupateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prețToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewCamere = new System.Windows.Forms.ListView();
            this.btnCreateDb = new System.Windows.Forms.Button();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.lbDisponibilitate = new System.Windows.Forms.Label();
            this.bazadedateDataSet = new projecttt.bazadedateDataSet();
            this.rezervari_date_clientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervari_date_clientiTableAdapter = new projecttt.bazadedateDataSetTableAdapters.Rezervari_date_clientiTableAdapter();
            this.tableAdapterManager = new projecttt.bazadedateDataSetTableAdapters.TableAdapterManager();
            this.rezervari_date_clientiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rezervari_date_clientiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rezervari_date_clientiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.prenumeTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLoad = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnPrint = new System.Windows.Forms.Button();
            numeLabel = new System.Windows.Forms.Label();
            prenumeLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            this.cmsCheckIn.SuspendLayout();
            this.cmsCheckOut.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervari_date_clientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervari_date_clientiBindingNavigator)).BeginInit();
            this.rezervari_date_clientiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezervari_date_clientiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // numeLabel
            // 
            numeLabel.AutoSize = true;
            numeLabel.Location = new System.Drawing.Point(1136, 69);
            numeLabel.Name = "numeLabel";
            numeLabel.Size = new System.Drawing.Size(74, 22);
            numeLabel.TabIndex = 36;
            numeLabel.Text = "Nume:";
            // 
            // prenumeLabel
            // 
            prenumeLabel.AutoSize = true;
            prenumeLabel.Location = new System.Drawing.Point(1108, 119);
            prenumeLabel.Name = "prenumeLabel";
            prenumeLabel.Size = new System.Drawing.Size(102, 22);
            prenumeLabel.TabIndex = 38;
            prenumeLabel.Text = "Prenume:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(1122, 159);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(88, 22);
            telefonLabel.TabIndex = 40;
            telefonLabel.Text = "Telefon:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(1122, 202);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(72, 22);
            emailLabel.TabIndex = 42;
            emailLabel.Text = "Email:";
            // 
            // btnRezerva
            // 
            this.btnRezerva.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnRezerva.Location = new System.Drawing.Point(961, 122);
            this.btnRezerva.Margin = new System.Windows.Forms.Padding(4);
            this.btnRezerva.Name = "btnRezerva";
            this.btnRezerva.Size = new System.Drawing.Size(139, 70);
            this.btnRezerva.TabIndex = 0;
            this.btnRezerva.Text = "Rezerva!";
            this.btnRezerva.UseVisualStyleBackColor = false;
            this.btnRezerva.Click += new System.EventHandler(this.btnRezerva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label1.Location = new System.Drawing.Point(202, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "INFORMATII CLIENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(90, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "NUME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(54, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "PRENUME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(60, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "TELEFON:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(85, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "EMAIL:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label6.Location = new System.Drawing.Point(546, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "ALEGE GAMERA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.ContextMenuStrip = this.cmsCheckIn;
            this.label7.Location = new System.Drawing.Point(479, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Check-in";
            // 
            // cmsCheckIn
            // 
            this.cmsCheckIn.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsCheckIn.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsCheckIn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oraCheckinToolStripMenuItem});
            this.cmsCheckIn.Name = "contextMenuStrip1";
            this.cmsCheckIn.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsCheckIn.Size = new System.Drawing.Size(243, 46);
            this.cmsCheckIn.Opening += new System.ComponentModel.CancelEventHandler(this.cmsCheckIn_Opening_1);
            // 
            // oraCheckinToolStripMenuItem
            // 
            this.oraCheckinToolStripMenuItem.Name = "oraCheckinToolStripMenuItem";
            this.oraCheckinToolStripMenuItem.Size = new System.Drawing.Size(242, 42);
            this.oraCheckinToolStripMenuItem.Text = "Ora Check-in";
            // 
            // dtpInceput
            // 
            this.dtpInceput.Location = new System.Drawing.Point(581, 122);
            this.dtpInceput.Margin = new System.Windows.Forms.Padding(4);
            this.dtpInceput.Name = "dtpInceput";
            this.dtpInceput.Size = new System.Drawing.Size(372, 28);
            this.dtpInceput.TabIndex = 9;
            // 
            // cbCamere
            // 
            this.cbCamere.BackColor = System.Drawing.Color.LightPink;
            this.cbCamere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamere.FormattingEnabled = true;
            this.cbCamere.Location = new System.Drawing.Point(533, 84);
            this.cbCamere.Margin = new System.Windows.Forms.Padding(4);
            this.cbCamere.Name = "cbCamere";
            this.cbCamere.Size = new System.Drawing.Size(180, 30);
            this.cbCamere.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.ContextMenuStrip = this.cmsCheckOut;
            this.label8.Location = new System.Drawing.Point(466, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Check-out";
            // 
            // cmsCheckOut
            // 
            this.cmsCheckOut.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsCheckOut.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsCheckOut.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oraCheckoutToolStripMenuItem});
            this.cmsCheckOut.Name = "contextMenuStrip1";
            this.cmsCheckOut.Size = new System.Drawing.Size(258, 46);
            this.cmsCheckOut.Opening += new System.ComponentModel.CancelEventHandler(this.cmsCheckOut_Opening);
            // 
            // oraCheckoutToolStripMenuItem
            // 
            this.oraCheckoutToolStripMenuItem.Name = "oraCheckoutToolStripMenuItem";
            this.oraCheckoutToolStripMenuItem.Size = new System.Drawing.Size(257, 42);
            this.oraCheckoutToolStripMenuItem.Text = "Ora Check-out";
            // 
            // dtpSfarsit
            // 
            this.dtpSfarsit.Location = new System.Drawing.Point(581, 168);
            this.dtpSfarsit.Margin = new System.Windows.Forms.Padding(4);
            this.dtpSfarsit.Name = "dtpSfarsit";
            this.dtpSfarsit.Size = new System.Drawing.Size(372, 28);
            this.dtpSfarsit.TabIndex = 12;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(188, 91);
            this.tbNume.Margin = new System.Windows.Forms.Padding(4);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(235, 28);
            this.tbNume.TabIndex = 13;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(188, 127);
            this.tbPrenume.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(235, 28);
            this.tbPrenume.TabIndex = 14;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(188, 200);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(235, 28);
            this.tbEmail.TabIndex = 15;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(188, 163);
            this.tbTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(235, 28);
            this.tbTelefon.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(466, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Pret final:";
            // 
            // tbPretFinal
            // 
            this.tbPretFinal.Location = new System.Drawing.Point(581, 214);
            this.tbPretFinal.Name = "tbPretFinal";
            this.tbPretFinal.Size = new System.Drawing.Size(250, 28);
            this.tbPretFinal.TabIndex = 18;
            // 
            // tbPretPeNoapte
            // 
            this.tbPretPeNoapte.BackColor = System.Drawing.Color.White;
            this.tbPretPeNoapte.Location = new System.Drawing.Point(778, 86);
            this.tbPretPeNoapte.Name = "tbPretPeNoapte";
            this.tbPretPeNoapte.Size = new System.Drawing.Size(86, 28);
            this.tbPretPeNoapte.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(794, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "Pret:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervariToolStripMenuItem,
            this.vizualizarePerioadeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1369, 30);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rezervariToolStripMenuItem
            // 
            this.rezervariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeRezervareToolStripMenuItem});
            this.rezervariToolStripMenuItem.Name = "rezervariToolStripMenuItem";
            this.rezervariToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
            this.rezervariToolStripMenuItem.Text = "Rezervari";
            // 
            // stergeRezervareToolStripMenuItem
            // 
            this.stergeRezervareToolStripMenuItem.Enabled = false;
            this.stergeRezervareToolStripMenuItem.Name = "stergeRezervareToolStripMenuItem";
            this.stergeRezervareToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.stergeRezervareToolStripMenuItem.Text = "Șterge rezervare";
            this.stergeRezervareToolStripMenuItem.Click += new System.EventHandler(this.StergeRezervareToolStripMenuItem_Click);
            // 
            // vizualizarePerioadeToolStripMenuItem
            // 
            this.vizualizarePerioadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perioadeOcupateToolStripMenuItem});
            this.vizualizarePerioadeToolStripMenuItem.Name = "vizualizarePerioadeToolStripMenuItem";
            this.vizualizarePerioadeToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.vizualizarePerioadeToolStripMenuItem.Text = "Vizualizare perioade";
            // 
            // perioadeOcupateToolStripMenuItem
            // 
            this.perioadeOcupateToolStripMenuItem.Name = "perioadeOcupateToolStripMenuItem";
            this.perioadeOcupateToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.perioadeOcupateToolStripMenuItem.Text = "perioade ocupate";
            this.perioadeOcupateToolStripMenuItem.Click += new System.EventHandler(this.perioadeOcupateToolStripMenuItem_Click);
            // 
            // prețToolStripMenuItem
            // 
            this.prețToolStripMenuItem.Name = "prețToolStripMenuItem";
            this.prețToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.prețToolStripMenuItem.Text = "Ora";
            // 
            // listViewCamere
            // 
            this.listViewCamere.FullRowSelect = true;
            this.listViewCamere.HideSelection = false;
            this.listViewCamere.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewCamere.Location = new System.Drawing.Point(12, 248);
            this.listViewCamere.MultiSelect = false;
            this.listViewCamere.Name = "listViewCamere";
            this.listViewCamere.Size = new System.Drawing.Size(646, 125);
            this.listViewCamere.TabIndex = 28;
            this.listViewCamere.UseCompatibleStateImageBehavior = false;
            this.listViewCamere.View = System.Windows.Forms.View.Details;
            this.listViewCamere.SelectedIndexChanged += new System.EventHandler(this.listViewCamere_SelectedIndexChanged);
            // 
            // btnCreateDb
            // 
            this.btnCreateDb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateDb.Location = new System.Drawing.Point(334, 0);
            this.btnCreateDb.Margin = new System.Windows.Forms.Padding(7);
            this.btnCreateDb.Name = "btnCreateDb";
            this.btnCreateDb.Size = new System.Drawing.Size(205, 27);
            this.btnCreateDb.TabIndex = 29;
            this.btnCreateDb.Text = "CREATE xml";
            this.btnCreateDb.UseVisualStyleBackColor = false;
            this.btnCreateDb.Click += new System.EventHandler(this.btnCreateDb_Click);
            // 
            // lbDisponibilitate
            // 
            this.lbDisponibilitate.AutoSize = true;
            this.lbDisponibilitate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDisponibilitate.Location = new System.Drawing.Point(466, 214);
            this.lbDisponibilitate.Name = "lbDisponibilitate";
            this.lbDisponibilitate.Size = new System.Drawing.Size(2, 24);
            this.lbDisponibilitate.TabIndex = 33;
            // 
            // bazadedateDataSet
            // 
            this.bazadedateDataSet.DataSetName = "bazadedateDataSet";
            this.bazadedateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezervari_date_clientiBindingSource
            // 
            this.rezervari_date_clientiBindingSource.DataMember = "Rezervari-date clienti";
            this.rezervari_date_clientiBindingSource.DataSource = this.bazadedateDataSet;
            // 
            // rezervari_date_clientiTableAdapter
            // 
            this.rezervari_date_clientiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Rezervari_date_clientiTableAdapter = this.rezervari_date_clientiTableAdapter;
            this.tableAdapterManager.UpdateOrder = projecttt.bazadedateDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rezervari_date_clientiBindingNavigator
            // 
            this.rezervari_date_clientiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rezervari_date_clientiBindingNavigator.BindingSource = this.rezervari_date_clientiBindingSource;
            this.rezervari_date_clientiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rezervari_date_clientiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rezervari_date_clientiBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rezervari_date_clientiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.rezervari_date_clientiBindingNavigatorSaveItem});
            this.rezervari_date_clientiBindingNavigator.Location = new System.Drawing.Point(0, 30);
            this.rezervari_date_clientiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rezervari_date_clientiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rezervari_date_clientiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rezervari_date_clientiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rezervari_date_clientiBindingNavigator.Name = "rezervari_date_clientiBindingNavigator";
            this.rezervari_date_clientiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rezervari_date_clientiBindingNavigator.Size = new System.Drawing.Size(1369, 31);
            this.rezervari_date_clientiBindingNavigator.TabIndex = 34;
            this.rezervari_date_clientiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // rezervari_date_clientiBindingNavigatorSaveItem
            // 
            this.rezervari_date_clientiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rezervari_date_clientiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rezervari_date_clientiBindingNavigatorSaveItem.Image")));
            this.rezervari_date_clientiBindingNavigatorSaveItem.Name = "rezervari_date_clientiBindingNavigatorSaveItem";
            this.rezervari_date_clientiBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.rezervari_date_clientiBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // rezervari_date_clientiDataGridView
            // 
            this.rezervari_date_clientiDataGridView.AutoGenerateColumns = false;
            this.rezervari_date_clientiDataGridView.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.rezervari_date_clientiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezervari_date_clientiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.rezervari_date_clientiDataGridView.DataSource = this.rezervari_date_clientiBindingSource;
            this.rezervari_date_clientiDataGridView.Location = new System.Drawing.Point(12, 379);
            this.rezervari_date_clientiDataGridView.Name = "rezervari_date_clientiDataGridView";
            this.rezervari_date_clientiDataGridView.RowHeadersWidth = 51;
            this.rezervari_date_clientiDataGridView.RowTemplate.Height = 24;
            this.rezervari_date_clientiDataGridView.Size = new System.Drawing.Size(646, 228);
            this.rezervari_date_clientiDataGridView.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nume";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nume";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prenume";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenume";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // numeTextBox
            // 
            this.numeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervari_date_clientiBindingSource, "Nume", true));
            this.numeTextBox.Location = new System.Drawing.Point(1237, 66);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(120, 28);
            this.numeTextBox.TabIndex = 37;
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervari_date_clientiBindingSource, "Prenume", true));
            this.prenumeTextBox.Location = new System.Drawing.Point(1237, 113);
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(120, 28);
            this.prenumeTextBox.TabIndex = 39;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervari_date_clientiBindingSource, "Telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(1237, 156);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(120, 28);
            this.telefonTextBox.TabIndex = 41;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervari_date_clientiBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(1237, 200);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(120, 28);
            this.emailTextBox.TabIndex = 43;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(718, 287);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(568, 284);
            this.chart1.TabIndex = 44;
            this.chart1.Text = "chart1";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(718, 577);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(219, 30);
            this.btnLoad.TabIndex = 45;
            this.btnLoad.Text = "Incarca graficul";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1314, 345);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(23, 145);
            this.btnPrint.TabIndex = 46;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1369, 619);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.chart1);
            this.Controls.Add(numeLabel);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(prenumeLabel);
            this.Controls.Add(this.prenumeTextBox);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.rezervari_date_clientiDataGridView);
            this.Controls.Add(this.rezervari_date_clientiBindingNavigator);
            this.Controls.Add(this.lbDisponibilitate);
            this.Controls.Add(this.btnCreateDb);
            this.Controls.Add(this.listViewCamere);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPretPeNoapte);
            this.Controls.Add(this.tbPretFinal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.dtpSfarsit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbCamere);
            this.Controls.Add(this.dtpInceput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRezerva);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsCheckIn.ResumeLayout(false);
            this.cmsCheckOut.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervari_date_clientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervari_date_clientiBindingNavigator)).EndInit();
            this.rezervari_date_clientiBindingNavigator.ResumeLayout(false);
            this.rezervari_date_clientiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezervari_date_clientiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpInceput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpSfarsit;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPretFinal;
        private System.Windows.Forms.TextBox tbPretPeNoapte;
        private System.Windows.Forms.ComboBox cbCamere;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button btnRezerva;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rezervariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeRezervareToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsCheckIn;
        private System.Windows.Forms.ToolStripMenuItem prețToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oraCheckinToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsCheckOut;
        private System.Windows.Forms.ToolStripMenuItem oraCheckoutToolStripMenuItem;
        private System.Windows.Forms.ListView listViewCamere;
        private System.Windows.Forms.ToolStripMenuItem vizualizarePerioadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perioadeOcupateToolStripMenuItem;
        private System.Windows.Forms.Button btnCreateDb;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Label lbDisponibilitate;
        private bazadedateDataSet bazadedateDataSet;
        private System.Windows.Forms.BindingSource rezervari_date_clientiBindingSource;
        private bazadedateDataSetTableAdapters.Rezervari_date_clientiTableAdapter rezervari_date_clientiTableAdapter;
        private bazadedateDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rezervari_date_clientiBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton rezervari_date_clientiBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView rezervari_date_clientiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox prenumeTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnLoad;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnPrint;
    }
}

