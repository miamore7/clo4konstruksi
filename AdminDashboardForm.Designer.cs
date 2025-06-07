namespace clo4konstruksi
{
    partial class AdminDashboardForm
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
            this.logoutButton = new MetroFramework.Controls.MetroButton();
            this.AdminDashboardTabControl = new MetroFramework.Controls.MetroTabControl();
            this.barangTabPage = new MetroFramework.Controls.MetroTabPage();
            this.loadDataButton = new MetroFramework.Controls.MetroButton();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.akunTabPage = new MetroFramework.Controls.MetroTabPage();
            this.loadAdminButton = new MetroFramework.Controls.MetroButton();
            this.setInactiveButton = new MetroFramework.Controls.MetroButton();
            this.setActiveButton = new MetroFramework.Controls.MetroButton();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.gudangTabPage = new MetroFramework.Controls.MetroTabPage();
            this.merkTextBox = new MetroFramework.Controls.MetroTextBox();
            this.tambahBarangButton = new MetroFramework.Controls.MetroButton();
            this.kategoriComboBox = new MetroFramework.Controls.MetroComboBox();
            this.jumlahBarangTextBox = new MetroFramework.Controls.MetroTextBox();
            this.namaBarangTextBox = new MetroFramework.Controls.MetroTextBox();
            this.statusGudangLabel = new MetroFramework.Controls.MetroLabel();
            this.barangKeluarTabPage = new MetroFramework.Controls.MetroTabPage();
            this.keluarkanButton = new MetroFramework.Controls.MetroButton();
            this.jumlahKeluarTextBox = new MetroFramework.Controls.MetroTextBox();
            this.logKeluarLabel = new MetroFramework.Controls.MetroLabel();
            this.jumlahKeluarLabel = new MetroFramework.Controls.MetroLabel();
            this.idBarangKeluarTextBox = new MetroFramework.Controls.MetroTextBox();
            this.idBarangKeluarLabel = new MetroFramework.Controls.MetroLabel();
            this.AdminDashboardTabControl.SuspendLayout();
            this.barangTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            this.akunTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.gudangTabPage.SuspendLayout();
            this.barangKeluarTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(701, 31);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseSelectable = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // AdminDashboardTabControl
            // 
            this.AdminDashboardTabControl.Controls.Add(this.barangTabPage);
            this.AdminDashboardTabControl.Controls.Add(this.akunTabPage);
            this.AdminDashboardTabControl.Controls.Add(this.gudangTabPage);
            this.AdminDashboardTabControl.Controls.Add(this.barangKeluarTabPage);
            this.AdminDashboardTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminDashboardTabControl.Location = new System.Drawing.Point(20, 60);
            this.AdminDashboardTabControl.Name = "AdminDashboardTabControl";
            this.AdminDashboardTabControl.SelectedIndex = 0;
            this.AdminDashboardTabControl.Size = new System.Drawing.Size(760, 370);
            this.AdminDashboardTabControl.TabIndex = 6;
            this.AdminDashboardTabControl.UseSelectable = true;
            // 
            // barangTabPage
            // 
            this.barangTabPage.Controls.Add(this.loadDataButton);
            this.barangTabPage.Controls.Add(this.itemsDataGridView);
            this.barangTabPage.HorizontalScrollbarBarColor = true;
            this.barangTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.barangTabPage.HorizontalScrollbarSize = 10;
            this.barangTabPage.Location = new System.Drawing.Point(4, 38);
            this.barangTabPage.Name = "barangTabPage";
            this.barangTabPage.Size = new System.Drawing.Size(752, 328);
            this.barangTabPage.TabIndex = 0;
            this.barangTabPage.Text = "Data Barang";
            this.barangTabPage.VerticalScrollbarBarColor = true;
            this.barangTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.barangTabPage.VerticalScrollbarSize = 10;
            // 
            // loadDataButton
            // 
            this.loadDataButton.Location = new System.Drawing.Point(329, 256);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(105, 23);
            this.loadDataButton.TabIndex = 3;
            this.loadDataButton.Text = "Memuat Data";
            this.loadDataButton.UseSelectable = true;
            this.loadDataButton.Click += new System.EventHandler(this.loadDataButton_Click);
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.AllowUserToAddRows = false;
            this.itemsDataGridView.AllowUserToDeleteRows = false;
            this.itemsDataGridView.AllowUserToOrderColumns = true;
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.ReadOnly = true;
            this.itemsDataGridView.Size = new System.Drawing.Size(752, 250);
            this.itemsDataGridView.TabIndex = 2;
            // 
            // akunTabPage
            // 
            this.akunTabPage.Controls.Add(this.loadAdminButton);
            this.akunTabPage.Controls.Add(this.setInactiveButton);
            this.akunTabPage.Controls.Add(this.setActiveButton);
            this.akunTabPage.Controls.Add(this.usersDataGridView);
            this.akunTabPage.HorizontalScrollbarBarColor = true;
            this.akunTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.akunTabPage.HorizontalScrollbarSize = 10;
            this.akunTabPage.Location = new System.Drawing.Point(4, 38);
            this.akunTabPage.Name = "akunTabPage";
            this.akunTabPage.Size = new System.Drawing.Size(752, 328);
            this.akunTabPage.TabIndex = 1;
            this.akunTabPage.Text = "Manajemen Akun";
            this.akunTabPage.VerticalScrollbarBarColor = true;
            this.akunTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.akunTabPage.VerticalScrollbarSize = 10;
            // 
            // loadAdminButton
            // 
            this.loadAdminButton.Location = new System.Drawing.Point(216, 256);
            this.loadAdminButton.Name = "loadAdminButton";
            this.loadAdminButton.Size = new System.Drawing.Size(100, 50);
            this.loadAdminButton.TabIndex = 5;
            this.loadAdminButton.Text = "Load Admin";
            this.loadAdminButton.UseSelectable = true;
            this.loadAdminButton.Click += new System.EventHandler(this.loadAdminButton_Click);
            // 
            // setInactiveButton
            // 
            this.setInactiveButton.Location = new System.Drawing.Point(428, 256);
            this.setInactiveButton.Name = "setInactiveButton";
            this.setInactiveButton.Size = new System.Drawing.Size(100, 50);
            this.setInactiveButton.TabIndex = 4;
            this.setInactiveButton.Text = "Non-Aktifkan";
            this.setInactiveButton.UseSelectable = true;
            this.setInactiveButton.Click += new System.EventHandler(this.setInactiveButton_Click);
            // 
            // setActiveButton
            // 
            this.setActiveButton.Location = new System.Drawing.Point(322, 256);
            this.setActiveButton.Name = "setActiveButton";
            this.setActiveButton.Size = new System.Drawing.Size(100, 50);
            this.setActiveButton.TabIndex = 3;
            this.setActiveButton.Text = "Aktifkan";
            this.setActiveButton.UseSelectable = true;
            this.setActiveButton.Click += new System.EventHandler(this.setActiveButton_Click);
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AllowUserToDeleteRows = false;
            this.usersDataGridView.AllowUserToOrderColumns = true;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            this.usersDataGridView.Size = new System.Drawing.Size(752, 250);
            this.usersDataGridView.TabIndex = 2;
            // 
            // gudangTabPage
            // 
            this.gudangTabPage.Controls.Add(this.merkTextBox);
            this.gudangTabPage.Controls.Add(this.tambahBarangButton);
            this.gudangTabPage.Controls.Add(this.kategoriComboBox);
            this.gudangTabPage.Controls.Add(this.jumlahBarangTextBox);
            this.gudangTabPage.Controls.Add(this.namaBarangTextBox);
            this.gudangTabPage.Controls.Add(this.statusGudangLabel);
            this.gudangTabPage.HorizontalScrollbarBarColor = true;
            this.gudangTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.gudangTabPage.HorizontalScrollbarSize = 10;
            this.gudangTabPage.Location = new System.Drawing.Point(4, 38);
            this.gudangTabPage.Name = "gudangTabPage";
            this.gudangTabPage.Size = new System.Drawing.Size(752, 328);
            this.gudangTabPage.TabIndex = 2;
            this.gudangTabPage.Text = "Operasi Gudang";
            this.gudangTabPage.VerticalScrollbarBarColor = true;
            this.gudangTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.gudangTabPage.VerticalScrollbarSize = 10;
            // 
            // merkTextBox
            // 
            // 
            // 
            // 
            this.merkTextBox.CustomButton.Image = null;
            this.merkTextBox.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.merkTextBox.CustomButton.Name = "";
            this.merkTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.merkTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.merkTextBox.CustomButton.TabIndex = 1;
            this.merkTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.merkTextBox.CustomButton.UseSelectable = true;
            this.merkTextBox.CustomButton.Visible = false;
            this.merkTextBox.Lines = new string[0];
            this.merkTextBox.Location = new System.Drawing.Point(92, 83);
            this.merkTextBox.MaxLength = 32767;
            this.merkTextBox.Name = "merkTextBox";
            this.merkTextBox.PasswordChar = '\0';
            this.merkTextBox.PromptText = "Merk HP/Laptop";
            this.merkTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.merkTextBox.SelectedText = "";
            this.merkTextBox.SelectionLength = 0;
            this.merkTextBox.SelectionStart = 0;
            this.merkTextBox.ShortcutsEnabled = true;
            this.merkTextBox.Size = new System.Drawing.Size(200, 23);
            this.merkTextBox.TabIndex = 9;
            this.merkTextBox.UseSelectable = true;
            this.merkTextBox.WaterMark = "Merk HP/Laptop";
            this.merkTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.merkTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tambahBarangButton
            // 
            this.tambahBarangButton.Location = new System.Drawing.Point(132, 170);
            this.tambahBarangButton.Name = "tambahBarangButton";
            this.tambahBarangButton.Size = new System.Drawing.Size(100, 23);
            this.tambahBarangButton.TabIndex = 8;
            this.tambahBarangButton.Text = "Tambah Barang";
            this.tambahBarangButton.UseSelectable = true;
            this.tambahBarangButton.Click += new System.EventHandler(this.tambahBarangButton_Click);
            // 
            // kategoriComboBox
            // 
            this.kategoriComboBox.FormattingEnabled = true;
            this.kategoriComboBox.ItemHeight = 23;
            this.kategoriComboBox.Items.AddRange(new object[] {
            "HP",
            "Laptop"});
            this.kategoriComboBox.Location = new System.Drawing.Point(92, 48);
            this.kategoriComboBox.Name = "kategoriComboBox";
            this.kategoriComboBox.Size = new System.Drawing.Size(121, 29);
            this.kategoriComboBox.TabIndex = 7;
            this.kategoriComboBox.UseSelectable = true;
            // 
            // jumlahBarangTextBox
            // 
            // 
            // 
            // 
            this.jumlahBarangTextBox.CustomButton.Image = null;
            this.jumlahBarangTextBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.jumlahBarangTextBox.CustomButton.Name = "";
            this.jumlahBarangTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.jumlahBarangTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.jumlahBarangTextBox.CustomButton.TabIndex = 1;
            this.jumlahBarangTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.jumlahBarangTextBox.CustomButton.UseSelectable = true;
            this.jumlahBarangTextBox.CustomButton.Visible = false;
            this.jumlahBarangTextBox.Lines = new string[0];
            this.jumlahBarangTextBox.Location = new System.Drawing.Point(92, 141);
            this.jumlahBarangTextBox.MaxLength = 32767;
            this.jumlahBarangTextBox.Name = "jumlahBarangTextBox";
            this.jumlahBarangTextBox.PasswordChar = '\0';
            this.jumlahBarangTextBox.PromptText = "Jumlah";
            this.jumlahBarangTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.jumlahBarangTextBox.SelectedText = "";
            this.jumlahBarangTextBox.SelectionLength = 0;
            this.jumlahBarangTextBox.SelectionStart = 0;
            this.jumlahBarangTextBox.ShortcutsEnabled = true;
            this.jumlahBarangTextBox.Size = new System.Drawing.Size(75, 23);
            this.jumlahBarangTextBox.TabIndex = 6;
            this.jumlahBarangTextBox.UseSelectable = true;
            this.jumlahBarangTextBox.WaterMark = "Jumlah";
            this.jumlahBarangTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.jumlahBarangTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // namaBarangTextBox
            // 
            // 
            // 
            // 
            this.namaBarangTextBox.CustomButton.Image = null;
            this.namaBarangTextBox.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.namaBarangTextBox.CustomButton.Name = "";
            this.namaBarangTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.namaBarangTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.namaBarangTextBox.CustomButton.TabIndex = 1;
            this.namaBarangTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.namaBarangTextBox.CustomButton.UseSelectable = true;
            this.namaBarangTextBox.CustomButton.Visible = false;
            this.namaBarangTextBox.Lines = new string[0];
            this.namaBarangTextBox.Location = new System.Drawing.Point(92, 112);
            this.namaBarangTextBox.MaxLength = 32767;
            this.namaBarangTextBox.Name = "namaBarangTextBox";
            this.namaBarangTextBox.PasswordChar = '\0';
            this.namaBarangTextBox.PromptText = "Nama Barang";
            this.namaBarangTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.namaBarangTextBox.SelectedText = "";
            this.namaBarangTextBox.SelectionLength = 0;
            this.namaBarangTextBox.SelectionStart = 0;
            this.namaBarangTextBox.ShortcutsEnabled = true;
            this.namaBarangTextBox.Size = new System.Drawing.Size(200, 23);
            this.namaBarangTextBox.TabIndex = 5;
            this.namaBarangTextBox.UseSelectable = true;
            this.namaBarangTextBox.WaterMark = "Nama Barang";
            this.namaBarangTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.namaBarangTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // statusGudangLabel
            // 
            this.statusGudangLabel.AutoSize = true;
            this.statusGudangLabel.Location = new System.Drawing.Point(0, 9);
            this.statusGudangLabel.Name = "statusGudangLabel";
            this.statusGudangLabel.Size = new System.Drawing.Size(96, 19);
            this.statusGudangLabel.TabIndex = 2;
            this.statusGudangLabel.Text = "Status Gudang:";
            // 
            // barangKeluarTabPage
            // 
            this.barangKeluarTabPage.Controls.Add(this.keluarkanButton);
            this.barangKeluarTabPage.Controls.Add(this.jumlahKeluarTextBox);
            this.barangKeluarTabPage.Controls.Add(this.logKeluarLabel);
            this.barangKeluarTabPage.Controls.Add(this.jumlahKeluarLabel);
            this.barangKeluarTabPage.Controls.Add(this.idBarangKeluarTextBox);
            this.barangKeluarTabPage.Controls.Add(this.idBarangKeluarLabel);
            this.barangKeluarTabPage.HorizontalScrollbarBarColor = true;
            this.barangKeluarTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.barangKeluarTabPage.HorizontalScrollbarSize = 10;
            this.barangKeluarTabPage.Location = new System.Drawing.Point(4, 38);
            this.barangKeluarTabPage.Name = "barangKeluarTabPage";
            this.barangKeluarTabPage.Size = new System.Drawing.Size(752, 328);
            this.barangKeluarTabPage.TabIndex = 3;
            this.barangKeluarTabPage.Text = "Barang Keluar";
            this.barangKeluarTabPage.VerticalScrollbarBarColor = true;
            this.barangKeluarTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.barangKeluarTabPage.VerticalScrollbarSize = 10;
            // 
            // keluarkanButton
            // 
            this.keluarkanButton.Location = new System.Drawing.Point(278, 129);
            this.keluarkanButton.Name = "keluarkanButton";
            this.keluarkanButton.Size = new System.Drawing.Size(75, 23);
            this.keluarkanButton.TabIndex = 7;
            this.keluarkanButton.Text = "Proses";
            this.keluarkanButton.UseSelectable = true;
            this.keluarkanButton.Click += new System.EventHandler(this.keluarkanButton_Click);
            // 
            // jumlahKeluarTextBox
            // 
            // 
            // 
            // 
            this.jumlahKeluarTextBox.CustomButton.Image = null;
            this.jumlahKeluarTextBox.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.jumlahKeluarTextBox.CustomButton.Name = "";
            this.jumlahKeluarTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.jumlahKeluarTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.jumlahKeluarTextBox.CustomButton.TabIndex = 1;
            this.jumlahKeluarTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.jumlahKeluarTextBox.CustomButton.UseSelectable = true;
            this.jumlahKeluarTextBox.CustomButton.Visible = false;
            this.jumlahKeluarTextBox.Lines = new string[0];
            this.jumlahKeluarTextBox.Location = new System.Drawing.Point(307, 81);
            this.jumlahKeluarTextBox.MaxLength = 32767;
            this.jumlahKeluarTextBox.Name = "jumlahKeluarTextBox";
            this.jumlahKeluarTextBox.PasswordChar = '\0';
            this.jumlahKeluarTextBox.PromptText = "Jumlah";
            this.jumlahKeluarTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.jumlahKeluarTextBox.SelectedText = "";
            this.jumlahKeluarTextBox.SelectionLength = 0;
            this.jumlahKeluarTextBox.SelectionStart = 0;
            this.jumlahKeluarTextBox.ShortcutsEnabled = true;
            this.jumlahKeluarTextBox.Size = new System.Drawing.Size(100, 23);
            this.jumlahKeluarTextBox.TabIndex = 6;
            this.jumlahKeluarTextBox.UseSelectable = true;
            this.jumlahKeluarTextBox.WaterMark = "Jumlah";
            this.jumlahKeluarTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.jumlahKeluarTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // logKeluarLabel
            // 
            this.logKeluarLabel.AutoSize = true;
            this.logKeluarLabel.Location = new System.Drawing.Point(293, 155);
            this.logKeluarLabel.Name = "logKeluarLabel";
            this.logKeluarLabel.Size = new System.Drawing.Size(44, 19);
            this.logKeluarLabel.TabIndex = 5;
            this.logKeluarLabel.Text = "Log: -";
            // 
            // jumlahKeluarLabel
            // 
            this.jumlahKeluarLabel.AutoSize = true;
            this.jumlahKeluarLabel.Location = new System.Drawing.Point(248, 81);
            this.jumlahKeluarLabel.Name = "jumlahKeluarLabel";
            this.jumlahKeluarLabel.Size = new System.Drawing.Size(53, 19);
            this.jumlahKeluarLabel.TabIndex = 4;
            this.jumlahKeluarLabel.Text = "Jumlah:";
            // 
            // idBarangKeluarTextBox
            // 
            // 
            // 
            // 
            this.idBarangKeluarTextBox.CustomButton.Image = null;
            this.idBarangKeluarTextBox.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.idBarangKeluarTextBox.CustomButton.Name = "";
            this.idBarangKeluarTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.idBarangKeluarTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idBarangKeluarTextBox.CustomButton.TabIndex = 1;
            this.idBarangKeluarTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idBarangKeluarTextBox.CustomButton.UseSelectable = true;
            this.idBarangKeluarTextBox.CustomButton.Visible = false;
            this.idBarangKeluarTextBox.Lines = new string[0];
            this.idBarangKeluarTextBox.Location = new System.Drawing.Point(307, 40);
            this.idBarangKeluarTextBox.MaxLength = 32767;
            this.idBarangKeluarTextBox.Name = "idBarangKeluarTextBox";
            this.idBarangKeluarTextBox.PasswordChar = '\0';
            this.idBarangKeluarTextBox.PromptText = "ID Barang";
            this.idBarangKeluarTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idBarangKeluarTextBox.SelectedText = "";
            this.idBarangKeluarTextBox.SelectionLength = 0;
            this.idBarangKeluarTextBox.SelectionStart = 0;
            this.idBarangKeluarTextBox.ShortcutsEnabled = true;
            this.idBarangKeluarTextBox.Size = new System.Drawing.Size(100, 23);
            this.idBarangKeluarTextBox.TabIndex = 3;
            this.idBarangKeluarTextBox.UseSelectable = true;
            this.idBarangKeluarTextBox.WaterMark = "ID Barang";
            this.idBarangKeluarTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.idBarangKeluarTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // idBarangKeluarLabel
            // 
            this.idBarangKeluarLabel.AutoSize = true;
            this.idBarangKeluarLabel.Location = new System.Drawing.Point(231, 40);
            this.idBarangKeluarLabel.Name = "idBarangKeluarLabel";
            this.idBarangKeluarLabel.Size = new System.Drawing.Size(70, 19);
            this.idBarangKeluarLabel.TabIndex = 2;
            this.idBarangKeluarLabel.Text = "ID Barang:";
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdminDashboardTabControl);
            this.Controls.Add(this.logoutButton);
            this.Name = "AdminDashboardForm";
            this.Text = "AdminDashboardForm";
            this.AdminDashboardTabControl.ResumeLayout(false);
            this.barangTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            this.akunTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.gudangTabPage.ResumeLayout(false);
            this.gudangTabPage.PerformLayout();
            this.barangKeluarTabPage.ResumeLayout(false);
            this.barangKeluarTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton logoutButton;
        private MetroFramework.Controls.MetroTabControl AdminDashboardTabControl;
        private MetroFramework.Controls.MetroTabPage barangTabPage;
        private MetroFramework.Controls.MetroTabPage akunTabPage;
        private MetroFramework.Controls.MetroTabPage gudangTabPage;
        private MetroFramework.Controls.MetroButton loadDataButton;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private MetroFramework.Controls.MetroButton setInactiveButton;
        private MetroFramework.Controls.MetroButton setActiveButton;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private MetroFramework.Controls.MetroLabel statusGudangLabel;
        private MetroFramework.Controls.MetroButton tambahBarangButton;
        private MetroFramework.Controls.MetroComboBox kategoriComboBox;
        private MetroFramework.Controls.MetroTextBox jumlahBarangTextBox;
        private MetroFramework.Controls.MetroTextBox namaBarangTextBox;
        private MetroFramework.Controls.MetroButton loadAdminButton;
        private MetroFramework.Controls.MetroTextBox merkTextBox;
        private MetroFramework.Controls.MetroTabPage barangKeluarTabPage;
        private MetroFramework.Controls.MetroTextBox idBarangKeluarTextBox;
        private MetroFramework.Controls.MetroLabel idBarangKeluarLabel;
        private MetroFramework.Controls.MetroButton keluarkanButton;
        private MetroFramework.Controls.MetroTextBox jumlahKeluarTextBox;
        private MetroFramework.Controls.MetroLabel logKeluarLabel;
        private MetroFramework.Controls.MetroLabel jumlahKeluarLabel;
    }
}