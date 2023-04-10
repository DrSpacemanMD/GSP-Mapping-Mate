namespace GSP_Mapping_Mate
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NewEv = new System.Windows.Forms.Button();
            this.RefreshData = new System.Windows.Forms.Button();
            this.EvidenceGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.CompAssinged = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectedComp = new System.Windows.Forms.TextBox();
            this.CompViewer = new System.Windows.Forms.DataGridView();
            this.RemoveComp = new System.Windows.Forms.Button();
            this.LoadEv = new System.Windows.Forms.Button();
            this.SaveEv = new System.Windows.Forms.Button();
            this.AddComp = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.ChooseFile = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.TextBox();
            this.Domain3 = new System.Windows.Forms.ComboBox();
            this.SubDomainCombo = new System.Windows.Forms.ComboBox();
            this.DomainCombo = new System.Windows.Forms.ComboBox();
            this.EvDesc = new System.Windows.Forms.TextBox();
            this.EvName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.EvLeaderBoard = new System.Windows.Forms.DataGridView();
            this.MappedComp = new System.Windows.Forms.Label();
            this.MissingCompStat = new System.Windows.Forms.Label();
            this.ScanForMissing = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MissingComp = new System.Windows.Forms.DataGridView();
            this.BuildTable = new System.Windows.Forms.Button();
            this.CompTable = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.Tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EvidenceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompAssinged)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompViewer)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EvLeaderBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissingComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(2564, 1072);
            this.Tabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NewEv);
            this.tabPage1.Controls.Add(this.RefreshData);
            this.tabPage1.Controls.Add(this.EvidenceGrid);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.CompAssinged);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.SelectedComp);
            this.tabPage1.Controls.Add(this.CompViewer);
            this.tabPage1.Controls.Add(this.RemoveComp);
            this.tabPage1.Controls.Add(this.LoadEv);
            this.tabPage1.Controls.Add(this.SaveEv);
            this.tabPage1.Controls.Add(this.AddComp);
            this.tabPage1.Controls.Add(this.OpenFile);
            this.tabPage1.Controls.Add(this.ChooseFile);
            this.tabPage1.Controls.Add(this.FileName);
            this.tabPage1.Controls.Add(this.Domain3);
            this.tabPage1.Controls.Add(this.SubDomainCombo);
            this.tabPage1.Controls.Add(this.DomainCombo);
            this.tabPage1.Controls.Add(this.EvDesc);
            this.tabPage1.Controls.Add(this.EvName);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(2556, 1034);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Evidence Explorer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // NewEv
            // 
            this.NewEv.Location = new System.Drawing.Point(623, 46);
            this.NewEv.Name = "NewEv";
            this.NewEv.Size = new System.Drawing.Size(170, 34);
            this.NewEv.TabIndex = 24;
            this.NewEv.Text = "New Evidence";
            this.NewEv.UseVisualStyleBackColor = true;
            this.NewEv.Click += new System.EventHandler(this.NewEv_Click);
            // 
            // RefreshData
            // 
            this.RefreshData.Location = new System.Drawing.Point(885, 771);
            this.RefreshData.Name = "RefreshData";
            this.RefreshData.Size = new System.Drawing.Size(170, 44);
            this.RefreshData.TabIndex = 23;
            this.RefreshData.Text = "Refresh";
            this.RefreshData.UseVisualStyleBackColor = true;
            this.RefreshData.Click += new System.EventHandler(this.RefreshData_Click);
            // 
            // EvidenceGrid
            // 
            this.EvidenceGrid.AllowUserToAddRows = false;
            this.EvidenceGrid.AllowUserToDeleteRows = false;
            this.EvidenceGrid.AllowUserToOrderColumns = true;
            this.EvidenceGrid.AllowUserToResizeColumns = false;
            this.EvidenceGrid.AllowUserToResizeRows = false;
            this.EvidenceGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EvidenceGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.EvidenceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EvidenceGrid.Location = new System.Drawing.Point(22, 722);
            this.EvidenceGrid.MultiSelect = false;
            this.EvidenceGrid.Name = "EvidenceGrid";
            this.EvidenceGrid.ReadOnly = true;
            this.EvidenceGrid.RowHeadersVisible = false;
            this.EvidenceGrid.RowHeadersWidth = 62;
            this.EvidenceGrid.RowTemplate.Height = 33;
            this.EvidenceGrid.Size = new System.Drawing.Size(855, 267);
            this.EvidenceGrid.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1182, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Assigned Competencies";
            // 
            // CompAssinged
            // 
            this.CompAssinged.AllowUserToAddRows = false;
            this.CompAssinged.AllowUserToDeleteRows = false;
            this.CompAssinged.AllowUserToResizeColumns = false;
            this.CompAssinged.AllowUserToResizeRows = false;
            this.CompAssinged.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompAssinged.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CompAssinged.BackgroundColor = System.Drawing.SystemColors.Window;
            this.CompAssinged.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompAssinged.ColumnHeadersVisible = false;
            this.CompAssinged.Location = new System.Drawing.Point(1182, 510);
            this.CompAssinged.Name = "CompAssinged";
            this.CompAssinged.ReadOnly = true;
            this.CompAssinged.RowHeadersVisible = false;
            this.CompAssinged.RowHeadersWidth = 62;
            this.CompAssinged.RowTemplate.Height = 33;
            this.CompAssinged.Size = new System.Drawing.Size(1048, 417);
            this.CompAssinged.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 567);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Evidence File Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1182, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Selected Competency ";
            // 
            // SelectedComp
            // 
            this.SelectedComp.Location = new System.Drawing.Point(1396, 68);
            this.SelectedComp.Name = "SelectedComp";
            this.SelectedComp.ReadOnly = true;
            this.SelectedComp.Size = new System.Drawing.Size(164, 31);
            this.SelectedComp.TabIndex = 17;
            // 
            // CompViewer
            // 
            this.CompViewer.AllowUserToAddRows = false;
            this.CompViewer.AllowUserToDeleteRows = false;
            this.CompViewer.AllowUserToResizeColumns = false;
            this.CompViewer.AllowUserToResizeRows = false;
            this.CompViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CompViewer.BackgroundColor = System.Drawing.SystemColors.Window;
            this.CompViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompViewer.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CompViewer.DefaultCellStyle = dataGridViewCellStyle2;
            this.CompViewer.Location = new System.Drawing.Point(1182, 110);
            this.CompViewer.Name = "CompViewer";
            this.CompViewer.ReadOnly = true;
            this.CompViewer.RowHeadersVisible = false;
            this.CompViewer.RowHeadersWidth = 62;
            this.CompViewer.RowTemplate.Height = 33;
            this.CompViewer.Size = new System.Drawing.Size(1048, 303);
            this.CompViewer.TabIndex = 16;
            // 
            // RemoveComp
            // 
            this.RemoveComp.Location = new System.Drawing.Point(1182, 945);
            this.RemoveComp.Name = "RemoveComp";
            this.RemoveComp.Size = new System.Drawing.Size(267, 44);
            this.RemoveComp.TabIndex = 15;
            this.RemoveComp.Text = "Remove Competency";
            this.RemoveComp.UseVisualStyleBackColor = true;
            this.RemoveComp.Click += new System.EventHandler(this.RemoveComp_Click);
            // 
            // LoadEv
            // 
            this.LoadEv.Location = new System.Drawing.Point(885, 722);
            this.LoadEv.Name = "LoadEv";
            this.LoadEv.Size = new System.Drawing.Size(170, 44);
            this.LoadEv.TabIndex = 12;
            this.LoadEv.Text = "Load Evidence";
            this.LoadEv.UseVisualStyleBackColor = true;
            this.LoadEv.Click += new System.EventHandler(this.LoadEv_Click);
            // 
            // SaveEv
            // 
            this.SaveEv.Location = new System.Drawing.Point(447, 46);
            this.SaveEv.Name = "SaveEv";
            this.SaveEv.Size = new System.Drawing.Size(170, 34);
            this.SaveEv.TabIndex = 11;
            this.SaveEv.Text = "Save Evidence";
            this.SaveEv.UseVisualStyleBackColor = true;
            this.SaveEv.Click += new System.EventHandler(this.SaveEv_Click);
            // 
            // AddComp
            // 
            this.AddComp.Location = new System.Drawing.Point(1182, 419);
            this.AddComp.Name = "AddComp";
            this.AddComp.Size = new System.Drawing.Size(230, 44);
            this.AddComp.TabIndex = 10;
            this.AddComp.Text = "Add Competency";
            this.AddComp.UseVisualStyleBackColor = true;
            this.AddComp.Click += new System.EventHandler(this.AddComp_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(186, 651);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(123, 42);
            this.OpenFile.TabIndex = 9;
            this.OpenFile.Text = "Open File";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // ChooseFile
            // 
            this.ChooseFile.Location = new System.Drawing.Point(22, 651);
            this.ChooseFile.Name = "ChooseFile";
            this.ChooseFile.Size = new System.Drawing.Size(123, 42);
            this.ChooseFile.TabIndex = 8;
            this.ChooseFile.Text = "Choose File";
            this.ChooseFile.UseVisualStyleBackColor = true;
            this.ChooseFile.Click += new System.EventHandler(this.ChooseFile_Click);
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(22, 604);
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Size = new System.Drawing.Size(1108, 31);
            this.FileName.TabIndex = 7;
            // 
            // Domain3
            // 
            this.Domain3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Domain3.FormattingEnabled = true;
            this.Domain3.Location = new System.Drawing.Point(2112, 21);
            this.Domain3.Name = "Domain3";
            this.Domain3.Size = new System.Drawing.Size(121, 33);
            this.Domain3.TabIndex = 5;
            this.Domain3.SelectedIndexChanged += new System.EventHandler(this.Domain3_SelectedIndexChanged);
            // 
            // SubDomainCombo
            // 
            this.SubDomainCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubDomainCombo.FormattingEnabled = true;
            this.SubDomainCombo.Location = new System.Drawing.Point(1707, 21);
            this.SubDomainCombo.Name = "SubDomainCombo";
            this.SubDomainCombo.Size = new System.Drawing.Size(384, 33);
            this.SubDomainCombo.TabIndex = 4;
            this.SubDomainCombo.SelectedIndexChanged += new System.EventHandler(this.SubDomainCombo_SelectedIndexChanged);
            // 
            // DomainCombo
            // 
            this.DomainCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DomainCombo.FormattingEnabled = true;
            this.DomainCombo.Location = new System.Drawing.Point(1182, 21);
            this.DomainCombo.Name = "DomainCombo";
            this.DomainCombo.Size = new System.Drawing.Size(492, 33);
            this.DomainCombo.TabIndex = 3;
            this.DomainCombo.SelectedIndexChanged += new System.EventHandler(this.DomainCombo_SelectedIndexChanged);
            // 
            // EvDesc
            // 
            this.EvDesc.Location = new System.Drawing.Point(22, 84);
            this.EvDesc.Multiline = true;
            this.EvDesc.Name = "EvDesc";
            this.EvDesc.PlaceholderText = "Evidence Descriptions and Comments";
            this.EvDesc.Size = new System.Drawing.Size(1108, 456);
            this.EvDesc.TabIndex = 1;
            // 
            // EvName
            // 
            this.EvName.Location = new System.Drawing.Point(22, 46);
            this.EvName.Name = "EvName";
            this.EvName.PlaceholderText = "Evidence Name";
            this.EvName.Size = new System.Drawing.Size(403, 31);
            this.EvName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.BuildTable);
            this.tabPage2.Controls.Add(this.CompTable);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.EvLeaderBoard);
            this.tabPage2.Controls.Add(this.MappedComp);
            this.tabPage2.Controls.Add(this.MissingCompStat);
            this.tabPage2.Controls.Add(this.ScanForMissing);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.MissingComp);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2556, 1034);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Competency Explorer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1500, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Evidence Leaderboard";
            // 
            // EvLeaderBoard
            // 
            this.EvLeaderBoard.AllowUserToAddRows = false;
            this.EvLeaderBoard.AllowUserToDeleteRows = false;
            this.EvLeaderBoard.AllowUserToResizeColumns = false;
            this.EvLeaderBoard.AllowUserToResizeRows = false;
            this.EvLeaderBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EvLeaderBoard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EvLeaderBoard.BackgroundColor = System.Drawing.SystemColors.Window;
            this.EvLeaderBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EvLeaderBoard.ColumnHeadersVisible = false;
            this.EvLeaderBoard.Location = new System.Drawing.Point(1500, 74);
            this.EvLeaderBoard.Name = "EvLeaderBoard";
            this.EvLeaderBoard.ReadOnly = true;
            this.EvLeaderBoard.RowHeadersVisible = false;
            this.EvLeaderBoard.RowHeadersWidth = 62;
            this.EvLeaderBoard.RowTemplate.Height = 33;
            this.EvLeaderBoard.Size = new System.Drawing.Size(1011, 318);
            this.EvLeaderBoard.TabIndex = 26;
            // 
            // MappedComp
            // 
            this.MappedComp.AutoSize = true;
            this.MappedComp.Location = new System.Drawing.Point(28, 416);
            this.MappedComp.Name = "MappedComp";
            this.MappedComp.Size = new System.Drawing.Size(254, 25);
            this.MappedComp.TabIndex = 25;
            this.MappedComp.Text = "Mapped Comptencies Count : ";
            this.MappedComp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MissingCompStat
            // 
            this.MissingCompStat.AutoSize = true;
            this.MissingCompStat.Location = new System.Drawing.Point(646, 416);
            this.MissingCompStat.Name = "MissingCompStat";
            this.MissingCompStat.Size = new System.Drawing.Size(248, 25);
            this.MissingCompStat.TabIndex = 24;
            this.MissingCompStat.Text = "Missing Comptencies Count : ";
            this.MissingCompStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ScanForMissing
            // 
            this.ScanForMissing.Location = new System.Drawing.Point(1124, 74);
            this.ScanForMissing.Name = "ScanForMissing";
            this.ScanForMissing.Size = new System.Drawing.Size(261, 41);
            this.ScanForMissing.TabIndex = 23;
            this.ScanForMissing.Text = "Scan";
            this.ScanForMissing.UseVisualStyleBackColor = true;
            this.ScanForMissing.Click += new System.EventHandler(this.ScanForMissing_Click);
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Missing Competencies";
            // 
            // MissingComp
            // 
            this.MissingComp.AllowUserToAddRows = false;
            this.MissingComp.AllowUserToDeleteRows = false;
            this.MissingComp.AllowUserToResizeColumns = false;
            this.MissingComp.AllowUserToResizeRows = false;
            this.MissingComp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MissingComp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MissingComp.BackgroundColor = System.Drawing.SystemColors.Window;
            this.MissingComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MissingComp.ColumnHeadersVisible = false;
            this.MissingComp.Location = new System.Drawing.Point(20, 74);
            this.MissingComp.Name = "MissingComp";
            this.MissingComp.ReadOnly = true;
            this.MissingComp.RowHeadersVisible = false;
            this.MissingComp.RowHeadersWidth = 62;
            this.MissingComp.RowTemplate.Height = 33;
            this.MissingComp.Size = new System.Drawing.Size(1011, 318);
            this.MissingComp.TabIndex = 21;
            // 
            // BuildTable
            // 
            this.BuildTable.Location = new System.Drawing.Point(1166, 968);
            this.BuildTable.Name = "BuildTable";
            this.BuildTable.Size = new System.Drawing.Size(261, 41);
            this.BuildTable.TabIndex = 29;
            this.BuildTable.Text = "Build Competency Table";
            this.BuildTable.UseVisualStyleBackColor = true;
            this.BuildTable.Click += new System.EventHandler(this.BuildTable_Click);
            // 
            // CompTable
            // 
            this.CompTable.AllowUserToAddRows = false;
            this.CompTable.AllowUserToDeleteRows = false;
            this.CompTable.AllowUserToResizeColumns = false;
            this.CompTable.AllowUserToResizeRows = false;
            this.CompTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CompTable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.CompTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompTable.ColumnHeadersVisible = false;
            this.CompTable.Location = new System.Drawing.Point(20, 505);
            this.CompTable.Name = "CompTable";
            this.CompTable.ReadOnly = true;
            this.CompTable.RowHeadersVisible = false;
            this.CompTable.RowHeadersWidth = 62;
            this.CompTable.RowTemplate.Height = 33;
            this.CompTable.Size = new System.Drawing.Size(2491, 438);
            this.CompTable.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Competency Table";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2564, 1072);
            this.Controls.Add(this.Tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GSP Mapping Mate";
            this.Tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EvidenceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompAssinged)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompViewer)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EvLeaderBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissingComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl Tabs;
        private TabPage tabPage1;
        private TextBox EvDesc;
        private TextBox EvName;
        private TabPage tabPage2;
        private ComboBox Domain3;
        private ComboBox SubDomainCombo;
        private ComboBox DomainCombo;
        private TextBox FileName;
        private Button OpenFile;
        private Button ChooseFile;
        private Button LoadEv;
        private Button SaveEv;
        private Button AddComp;
        private Button RemoveComp;
        private DataGridView CompViewer;
        private Label label1;
        private TextBox SelectedComp;
        private Label label2;
        private DataGridView CompAssinged;
        private Label label3;
        private Button RefreshData;
        private DataGridView EvidenceGrid;
        private Label label4;
        private DataGridView MissingComp;
        private Button ScanForMissing;
        private Label MappedComp;
        private Label MissingCompStat;
        private Label label5;
        private DataGridView EvLeaderBoard;
        private Button NewEv;
        private Label label6;
        private Button BuildTable;
        private DataGridView CompTable;
    }
}