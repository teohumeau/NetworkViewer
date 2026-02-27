namespace NetworkViewer
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.dataGridView_interfaces = new System.Windows.Forms.DataGridView();
            this.ComboBox_Interfaces = new System.Windows.Forms.ComboBox();
            this.dataGridView_netview = new System.Windows.Forms.DataGridView();
            this.Label_AdresseIP = new System.Windows.Forms.Label();
            this.progressBar_inResearch = new System.Windows.Forms.ProgressBar();
            this.BackgroundWorker_Scan = new System.ComponentModel.BackgroundWorker();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Interfaces = new System.Windows.Forms.TabPage();
            this.Button_RefreshInterfaces = new System.Windows.Forms.Button();
            this.tabPage_Scan = new System.Windows.Forms.TabPage();
            this.Button_StartScan = new System.Windows.Forms.Button();
            this.Button_RefreshComboBox = new System.Windows.Forms.Button();
            this.tabPage_RealTime = new System.Windows.Forms.TabPage();
            this.Label_RealTimeListHeader = new System.Windows.Forms.Label();
            this.ListBox_RealTime = new System.Windows.Forms.ListBox();
            this.NumericUpDown_Intervalle = new System.Windows.Forms.NumericUpDown();
            this.Label_Intervalle = new System.Windows.Forms.Label();
            this.Button_StopRealTime = new System.Windows.Forms.Button();
            this.Chart_RealTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Button_StartRealTime = new System.Windows.Forms.Button();
            this.TextBox_AddressToWatch = new System.Windows.Forms.TextBox();
            this.Label_AddressToWatch = new System.Windows.Forms.Label();
            this.BackgroundWorker_RealTime = new System.ComponentModel.BackgroundWorker();
            this.Timer_RealTime = new System.Windows.Forms.Timer(this.components);
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interface = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPv4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passerelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresseIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_interfaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_netview)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage_Interfaces.SuspendLayout();
            this.tabPage_Scan.SuspendLayout();
            this.tabPage_RealTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Intervalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_RealTime)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_interfaces
            // 
            this.dataGridView_interfaces.AllowUserToAddRows = false;
            this.dataGridView_interfaces.AllowUserToDeleteRows = false;
            this.dataGridView_interfaces.AllowUserToResizeColumns = false;
            this.dataGridView_interfaces.AllowUserToResizeRows = false;
            this.dataGridView_interfaces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_interfaces.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_interfaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_interfaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Interface,
            this.IPv4,
            this.Passerelle,
            this.Masque});
            this.dataGridView_interfaces.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_interfaces.Location = new System.Drawing.Point(7, 6);
            this.dataGridView_interfaces.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_interfaces.MultiSelect = false;
            this.dataGridView_interfaces.Name = "dataGridView_interfaces";
            this.dataGridView_interfaces.ReadOnly = true;
            this.dataGridView_interfaces.RowHeadersVisible = false;
            this.dataGridView_interfaces.RowHeadersWidth = 62;
            this.dataGridView_interfaces.RowTemplate.Height = 33;
            this.dataGridView_interfaces.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_interfaces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_interfaces.Size = new System.Drawing.Size(1118, 554);
            this.dataGridView_interfaces.TabIndex = 0;
            // 
            // ComboBox_Interfaces
            // 
            this.ComboBox_Interfaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Interfaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Interfaces.FormattingEnabled = true;
            this.ComboBox_Interfaces.Location = new System.Drawing.Point(152, 6);
            this.ComboBox_Interfaces.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox_Interfaces.Name = "ComboBox_Interfaces";
            this.ComboBox_Interfaces.Size = new System.Drawing.Size(462, 37);
            this.ComboBox_Interfaces.TabIndex = 4;
            this.ComboBox_Interfaces.SelectedIndexChanged += new System.EventHandler(this.ComboBox_interfaces_SelectedIndexChanged);
            // 
            // dataGridView_netview
            // 
            this.dataGridView_netview.AllowUserToAddRows = false;
            this.dataGridView_netview.AllowUserToDeleteRows = false;
            this.dataGridView_netview.AllowUserToResizeColumns = false;
            this.dataGridView_netview.AllowUserToResizeRows = false;
            this.dataGridView_netview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_netview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_netview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.AdresseIP,
            this.Ping,
            this.MAC});
            this.dataGridView_netview.Location = new System.Drawing.Point(7, 54);
            this.dataGridView_netview.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_netview.MultiSelect = false;
            this.dataGridView_netview.Name = "dataGridView_netview";
            this.dataGridView_netview.ReadOnly = true;
            this.dataGridView_netview.RowHeadersVisible = false;
            this.dataGridView_netview.RowHeadersWidth = 62;
            this.dataGridView_netview.RowTemplate.Height = 33;
            this.dataGridView_netview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_netview.Size = new System.Drawing.Size(1118, 502);
            this.dataGridView_netview.TabIndex = 5;
            // 
            // Label_AdresseIP
            // 
            this.Label_AdresseIP.AutoSize = true;
            this.Label_AdresseIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_AdresseIP.Location = new System.Drawing.Point(619, 8);
            this.Label_AdresseIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_AdresseIP.Name = "Label_AdresseIP";
            this.Label_AdresseIP.Size = new System.Drawing.Size(151, 32);
            this.Label_AdresseIP.TabIndex = 6;
            this.Label_AdresseIP.Text = "Adresse IP";
            // 
            // progressBar_inResearch
            // 
            this.progressBar_inResearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar_inResearch.Location = new System.Drawing.Point(7, 234);
            this.progressBar_inResearch.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar_inResearch.Name = "progressBar_inResearch";
            this.progressBar_inResearch.Size = new System.Drawing.Size(1118, 60);
            this.progressBar_inResearch.Step = 1;
            this.progressBar_inResearch.TabIndex = 7;
            this.progressBar_inResearch.Visible = false;
            // 
            // BackgroundWorker_Scan
            // 
            this.BackgroundWorker_Scan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_Ping_DoWork);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage_Interfaces);
            this.tabControl.Controls.Add(this.tabPage_Scan);
            this.tabControl.Controls.Add(this.tabPage_RealTime);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(14, 15);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1141, 651);
            this.tabControl.TabIndex = 8;
            // 
            // tabPage_Interfaces
            // 
            this.tabPage_Interfaces.Controls.Add(this.Button_RefreshInterfaces);
            this.tabPage_Interfaces.Controls.Add(this.dataGridView_interfaces);
            this.tabPage_Interfaces.Location = new System.Drawing.Point(4, 34);
            this.tabPage_Interfaces.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_Interfaces.Name = "tabPage_Interfaces";
            this.tabPage_Interfaces.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_Interfaces.Size = new System.Drawing.Size(1133, 613);
            this.tabPage_Interfaces.TabIndex = 0;
            this.tabPage_Interfaces.Text = "Interfaces";
            this.tabPage_Interfaces.UseVisualStyleBackColor = true;
            // 
            // Button_RefreshInterfaces
            // 
            this.Button_RefreshInterfaces.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_RefreshInterfaces.Location = new System.Drawing.Point(7, 566);
            this.Button_RefreshInterfaces.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_RefreshInterfaces.Name = "Button_RefreshInterfaces";
            this.Button_RefreshInterfaces.Size = new System.Drawing.Size(1118, 40);
            this.Button_RefreshInterfaces.TabIndex = 6;
            this.Button_RefreshInterfaces.Text = "Actualiser";
            this.Button_RefreshInterfaces.UseVisualStyleBackColor = true;
            this.Button_RefreshInterfaces.Click += new System.EventHandler(this.Button_RefreshInterfaces_Click);
            // 
            // tabPage_Scan
            // 
            this.tabPage_Scan.Controls.Add(this.progressBar_inResearch);
            this.tabPage_Scan.Controls.Add(this.Button_StartScan);
            this.tabPage_Scan.Controls.Add(this.dataGridView_netview);
            this.tabPage_Scan.Controls.Add(this.Button_RefreshComboBox);
            this.tabPage_Scan.Controls.Add(this.Label_AdresseIP);
            this.tabPage_Scan.Controls.Add(this.ComboBox_Interfaces);
            this.tabPage_Scan.Location = new System.Drawing.Point(4, 34);
            this.tabPage_Scan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_Scan.Name = "tabPage_Scan";
            this.tabPage_Scan.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_Scan.Size = new System.Drawing.Size(1133, 613);
            this.tabPage_Scan.TabIndex = 1;
            this.tabPage_Scan.Text = "Scan";
            this.tabPage_Scan.UseVisualStyleBackColor = true;
            // 
            // Button_StartScan
            // 
            this.Button_StartScan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_StartScan.Location = new System.Drawing.Point(7, 562);
            this.Button_StartScan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_StartScan.Name = "Button_StartScan";
            this.Button_StartScan.Size = new System.Drawing.Size(1118, 40);
            this.Button_StartScan.TabIndex = 9;
            this.Button_StartScan.Text = "Analyser le réseau";
            this.Button_StartScan.UseVisualStyleBackColor = true;
            this.Button_StartScan.Click += new System.EventHandler(this.Button_StartScan_Click);
            // 
            // Button_RefreshComboBox
            // 
            this.Button_RefreshComboBox.Location = new System.Drawing.Point(7, 8);
            this.Button_RefreshComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_RefreshComboBox.Name = "Button_RefreshComboBox";
            this.Button_RefreshComboBox.Size = new System.Drawing.Size(140, 40);
            this.Button_RefreshComboBox.TabIndex = 8;
            this.Button_RefreshComboBox.Text = "Actualiser";
            this.Button_RefreshComboBox.UseVisualStyleBackColor = true;
            this.Button_RefreshComboBox.Click += new System.EventHandler(this.Button_RefreshInterfaces_Click);
            // 
            // tabPage_RealTime
            // 
            this.tabPage_RealTime.Controls.Add(this.Label_RealTimeListHeader);
            this.tabPage_RealTime.Controls.Add(this.ListBox_RealTime);
            this.tabPage_RealTime.Controls.Add(this.NumericUpDown_Intervalle);
            this.tabPage_RealTime.Controls.Add(this.Label_Intervalle);
            this.tabPage_RealTime.Controls.Add(this.Button_StopRealTime);
            this.tabPage_RealTime.Controls.Add(this.Chart_RealTime);
            this.tabPage_RealTime.Controls.Add(this.Button_StartRealTime);
            this.tabPage_RealTime.Controls.Add(this.TextBox_AddressToWatch);
            this.tabPage_RealTime.Controls.Add(this.Label_AddressToWatch);
            this.tabPage_RealTime.Location = new System.Drawing.Point(4, 34);
            this.tabPage_RealTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_RealTime.Name = "tabPage_RealTime";
            this.tabPage_RealTime.Size = new System.Drawing.Size(1133, 613);
            this.tabPage_RealTime.TabIndex = 2;
            this.tabPage_RealTime.Text = "Temps réel";
            this.tabPage_RealTime.UseVisualStyleBackColor = true;
            // 
            // Label_RealTimeListHeader
            // 
            this.Label_RealTimeListHeader.AutoSize = true;
            this.Label_RealTimeListHeader.Location = new System.Drawing.Point(3, 55);
            this.Label_RealTimeListHeader.Name = "Label_RealTimeListHeader";
            this.Label_RealTimeListHeader.Size = new System.Drawing.Size(82, 25);
            this.Label_RealTimeListHeader.TabIndex = 8;
            this.Label_RealTimeListHeader.Text = "Latence";
            // 
            // ListBox_RealTime
            // 
            this.ListBox_RealTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListBox_RealTime.FormattingEnabled = true;
            this.ListBox_RealTime.ItemHeight = 25;
            this.ListBox_RealTime.Location = new System.Drawing.Point(8, 80);
            this.ListBox_RealTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListBox_RealTime.Name = "ListBox_RealTime";
            this.ListBox_RealTime.Size = new System.Drawing.Size(144, 504);
            this.ListBox_RealTime.TabIndex = 7;
            // 
            // NumericUpDown_Intervalle
            // 
            this.NumericUpDown_Intervalle.Location = new System.Drawing.Point(719, 11);
            this.NumericUpDown_Intervalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericUpDown_Intervalle.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NumericUpDown_Intervalle.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericUpDown_Intervalle.Name = "NumericUpDown_Intervalle";
            this.NumericUpDown_Intervalle.Size = new System.Drawing.Size(53, 30);
            this.NumericUpDown_Intervalle.TabIndex = 6;
            this.NumericUpDown_Intervalle.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericUpDown_Intervalle.ValueChanged += new System.EventHandler(this.NumericUpDown_Intervalle_ValueChanged);
            // 
            // Label_Intervalle
            // 
            this.Label_Intervalle.AutoSize = true;
            this.Label_Intervalle.Location = new System.Drawing.Point(496, 15);
            this.Label_Intervalle.Name = "Label_Intervalle";
            this.Label_Intervalle.Size = new System.Drawing.Size(218, 25);
            this.Label_Intervalle.TabIndex = 5;
            this.Label_Intervalle.Text = "Intervalle en secondes :";
            // 
            // Button_StopRealTime
            // 
            this.Button_StopRealTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_StopRealTime.Enabled = false;
            this.Button_StopRealTime.Location = new System.Drawing.Point(966, 8);
            this.Button_StopRealTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_StopRealTime.Name = "Button_StopRealTime";
            this.Button_StopRealTime.Size = new System.Drawing.Size(162, 40);
            this.Button_StopRealTime.TabIndex = 4;
            this.Button_StopRealTime.Text = "Stop";
            this.Button_StopRealTime.UseVisualStyleBackColor = true;
            this.Button_StopRealTime.Click += new System.EventHandler(this.Button_StopRealTime_Click);
            // 
            // Chart_RealTime
            // 
            this.Chart_RealTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.Chart_RealTime.ChartAreas.Add(chartArea1);
            this.Chart_RealTime.Location = new System.Drawing.Point(159, 55);
            this.Chart_RealTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Chart_RealTime.Name = "Chart_RealTime";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.Chart_RealTime.Series.Add(series1);
            this.Chart_RealTime.Size = new System.Drawing.Size(970, 551);
            this.Chart_RealTime.TabIndex = 3;
            // 
            // Button_StartRealTime
            // 
            this.Button_StartRealTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_StartRealTime.Enabled = false;
            this.Button_StartRealTime.Location = new System.Drawing.Point(798, 8);
            this.Button_StartRealTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_StartRealTime.Name = "Button_StartRealTime";
            this.Button_StartRealTime.Size = new System.Drawing.Size(162, 40);
            this.Button_StartRealTime.TabIndex = 2;
            this.Button_StartRealTime.Text = "Start";
            this.Button_StartRealTime.UseVisualStyleBackColor = true;
            this.Button_StartRealTime.Click += new System.EventHandler(this.Button_StartRealTime_Click);
            // 
            // TextBox_AddressToWatch
            // 
            this.TextBox_AddressToWatch.Location = new System.Drawing.Point(222, 11);
            this.TextBox_AddressToWatch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_AddressToWatch.Name = "TextBox_AddressToWatch";
            this.TextBox_AddressToWatch.Size = new System.Drawing.Size(267, 30);
            this.TextBox_AddressToWatch.TabIndex = 1;
            this.TextBox_AddressToWatch.TextChanged += new System.EventHandler(this.TextBox_AddressToWatch_TextChanged);
            // 
            // Label_AddressToWatch
            // 
            this.Label_AddressToWatch.AutoSize = true;
            this.Label_AddressToWatch.Location = new System.Drawing.Point(3, 15);
            this.Label_AddressToWatch.Name = "Label_AddressToWatch";
            this.Label_AddressToWatch.Size = new System.Drawing.Size(217, 25);
            this.Label_AddressToWatch.TabIndex = 0;
            this.Label_AddressToWatch.Text = "Adresse IP à surveiller :";
            // 
            // BackgroundWorker_RealTime
            // 
            this.BackgroundWorker_RealTime.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_RealTime_DoWork);
            // 
            // Timer_RealTime
            // 
            this.Timer_RealTime.Tick += new System.EventHandler(this.Timer_RealTime_Tick);
            // 
            // Type
            // 
            this.Type.Frozen = true;
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 93;
            // 
            // Interface
            // 
            this.Interface.Frozen = true;
            this.Interface.HeaderText = "Interface";
            this.Interface.MinimumWidth = 8;
            this.Interface.Name = "Interface";
            this.Interface.ReadOnly = true;
            this.Interface.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Interface.Width = 123;
            // 
            // IPv4
            // 
            this.IPv4.Frozen = true;
            this.IPv4.HeaderText = "Adresse IP";
            this.IPv4.MinimumWidth = 8;
            this.IPv4.Name = "IPv4";
            this.IPv4.ReadOnly = true;
            this.IPv4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IPv4.Width = 144;
            // 
            // Passerelle
            // 
            this.Passerelle.Frozen = true;
            this.Passerelle.HeaderText = "Passerelle";
            this.Passerelle.MinimumWidth = 8;
            this.Passerelle.Name = "Passerelle";
            this.Passerelle.ReadOnly = true;
            this.Passerelle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Passerelle.Width = 139;
            // 
            // Masque
            // 
            this.Masque.Frozen = true;
            this.Masque.HeaderText = "Masque sous-réseau";
            this.Masque.MinimumWidth = 8;
            this.Masque.Name = "Masque";
            this.Masque.ReadOnly = true;
            this.Masque.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Masque.Width = 213;
            // 
            // Nom
            // 
            this.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nom.Frozen = true;
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 8;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 89;
            // 
            // AdresseIP
            // 
            this.AdresseIP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AdresseIP.Frozen = true;
            this.AdresseIP.HeaderText = "Adresse IP";
            this.AdresseIP.MinimumWidth = 8;
            this.AdresseIP.Name = "AdresseIP";
            this.AdresseIP.ReadOnly = true;
            this.AdresseIP.Width = 144;
            // 
            // Ping
            // 
            this.Ping.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ping.Frozen = true;
            this.Ping.HeaderText = "Ping";
            this.Ping.MinimumWidth = 8;
            this.Ping.Name = "Ping";
            this.Ping.ReadOnly = true;
            this.Ping.Width = 87;
            // 
            // MAC
            // 
            this.MAC.Frozen = true;
            this.MAC.HeaderText = "Adresse MAC";
            this.MAC.MinimumWidth = 8;
            this.MAC.Name = "MAC";
            this.MAC.ReadOnly = true;
            this.MAC.Width = 150;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 681);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1182, 428);
            this.Name = "MainWindow";
            this.Text = "Network Viewer ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_interfaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_netview)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage_Interfaces.ResumeLayout(false);
            this.tabPage_Scan.ResumeLayout(false);
            this.tabPage_Scan.PerformLayout();
            this.tabPage_RealTime.ResumeLayout(false);
            this.tabPage_RealTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Intervalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_RealTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_interfaces;
        private System.Windows.Forms.ComboBox ComboBox_Interfaces;
        private System.Windows.Forms.DataGridView dataGridView_netview;
        private System.Windows.Forms.Label Label_AdresseIP;
        private System.Windows.Forms.ProgressBar progressBar_inResearch;
        private System.ComponentModel.BackgroundWorker BackgroundWorker_Scan;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_Interfaces;
        private System.Windows.Forms.TabPage tabPage_Scan;
        private System.Windows.Forms.Button Button_RefreshInterfaces;
        private System.Windows.Forms.Button Button_RefreshComboBox;
        private System.Windows.Forms.Button Button_StartScan;
        private System.Windows.Forms.TabPage tabPage_RealTime;
        private System.Windows.Forms.TextBox TextBox_AddressToWatch;
        private System.Windows.Forms.Label Label_AddressToWatch;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_RealTime;
        private System.Windows.Forms.Button Button_StartRealTime;
        private System.ComponentModel.BackgroundWorker BackgroundWorker_RealTime;
        private System.Windows.Forms.Button Button_StopRealTime;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Intervalle;
        private System.Windows.Forms.Label Label_Intervalle;
        private System.Windows.Forms.Timer Timer_RealTime;
        private System.Windows.Forms.ListBox ListBox_RealTime;
        private System.Windows.Forms.Label Label_RealTimeListHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interface;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPv4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passerelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresseIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ping;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAC;
    }
}

