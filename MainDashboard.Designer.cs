namespace clo4konstruksi
{
    partial class MainDashboard
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.barangTabPage = new MetroFramework.Controls.MetroTabPage();
            this.statusGudangLabel = new MetroFramework.Controls.MetroLabel();
            this.loadDataButton = new MetroFramework.Controls.MetroButton();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.gudangTabPage = new MetroFramework.Controls.MetroTabPage();
            this.tambahBarangButton = new MetroFramework.Controls.MetroButton();
            this.kategoriComboBox = new MetroFramework.Controls.MetroComboBox();
            this.jumlahBarangTextBox = new MetroFramework.Controls.MetroTextBox();
            this.merkTextBox = new MetroFramework.Controls.MetroTextBox();
            this.namaBarangTextBox = new MetroFramework.Controls.MetroTextBox();
            this.manajemenAkunButton = new MetroFramework.Controls.MetroButton();
            this.barangKeluarTabPage = new MetroFramework.Controls.MetroTabPage();
            this.idBarangKeluarLabel = new MetroFramework.Controls.MetroLabel();
            this.idBarangKeluarTextBox = new MetroFramework.Controls.MetroTextBox();
            this.jumlahKeluarLabel = new MetroFramework.Controls.MetroLabel();
            this.jumlahKeluarTextBox = new MetroFramework.Controls.MetroTextBox();
            this.keluarkanButton = new MetroFramework.Controls.MetroButton();
            this.logKeluarLabel = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.barangTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            this.gudangTabPage.SuspendLayout();
            this.barangKeluarTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(705, 31);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseSelectable = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.barangTabPage);
            this.metroTabControl1.Controls.Add(this.gudangTabPage);
            this.metroTabControl1.Controls.Add(this.barangKeluarTabPage);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(760, 370);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // barangTabPage
            // 
            this.barangTabPage.Controls.Add(this.statusGudangLabel);
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
            // statusGudangLabel
            // 
            this.statusGudangLabel.AutoSize = true;
            this.statusGudangLabel.Location = new System.Drawing.Point(0, 153);
            this.statusGudangLabel.Name = "statusGudangLabel";
            this.statusGudangLabel.Size = new System.Drawing.Size(106, 19);
            this.statusGudangLabel.TabIndex = 4;
            this.statusGudangLabel.Text = "Status Gudang: -";
            // 
            // loadDataButton
            // 
            this.loadDataButton.Location = new System.Drawing.Point(542, 156);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(207, 23);
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
            this.itemsDataGridView.Size = new System.Drawing.Size(752, 150);
            this.itemsDataGridView.TabIndex = 2;
            // 
            // gudangTabPage
            // 
            this.gudangTabPage.Controls.Add(this.tambahBarangButton);
            this.gudangTabPage.Controls.Add(this.kategoriComboBox);
            this.gudangTabPage.Controls.Add(this.jumlahBarangTextBox);
            this.gudangTabPage.Controls.Add(this.merkTextBox);
            this.gudangTabPage.Controls.Add(this.namaBarangTextBox);
            this.gudangTabPage.HorizontalScrollbarBarColor = true;
            this.gudangTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.gudangTabPage.HorizontalScrollbarSize = 10;
            this.gudangTabPage.Location = new System.Drawing.Point(4, 38);
            this.gudangTabPage.Name = "gudangTabPage";
            this.gudangTabPage.Size = new System.Drawing.Size(752, 328);
            this.gudangTabPage.TabIndex = 2;
            this.gudangTabPage.Text = "Barang Masuk";
            this.gudangTabPage.VerticalScrollbarBarColor = true;
            this.gudangTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.gudangTabPage.VerticalScrollbarSize = 10;
            // 
            // tambahBarangButton
            // 
            this.tambahBarangButton.Location = new System.Drawing.Point(393, 166);
            this.tambahBarangButton.Name = "tambahBarangButton";
            this.tambahBarangButton.Size = new System.Drawing.Size(121, 25);
            this.tambahBarangButton.TabIndex = 7;
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
            this.kategoriComboBox.Location = new System.Drawing.Point(393, 122);
            this.kategoriComboBox.Name = "kategoriComboBox";
            this.kategoriComboBox.Size = new System.Drawing.Size(121, 29);
            this.kategoriComboBox.TabIndex = 6;
            this.kategoriComboBox.UseSelectable = true;
            // 
            // jumlahBarangTextBox
            // 
            // 
            // 
            // 
            this.jumlahBarangTextBox.CustomButton.Image = null;
            this.jumlahBarangTextBox.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.jumlahBarangTextBox.CustomButton.Name = "";
            this.jumlahBarangTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.jumlahBarangTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.jumlahBarangTextBox.CustomButton.TabIndex = 1;
            this.jumlahBarangTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.jumlahBarangTextBox.CustomButton.UseSelectable = true;
            this.jumlahBarangTextBox.CustomButton.Visible = false;
            this.jumlahBarangTextBox.Lines = new string[0];
            this.jumlahBarangTextBox.Location = new System.Drawing.Point(215, 166);
            this.jumlahBarangTextBox.MaxLength = 32767;
            this.jumlahBarangTextBox.Name = "jumlahBarangTextBox";
            this.jumlahBarangTextBox.PasswordChar = '\0';
            this.jumlahBarangTextBox.PromptText = "Jumlah";
            this.jumlahBarangTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.jumlahBarangTextBox.SelectedText = "";
            this.jumlahBarangTextBox.SelectionLength = 0;
            this.jumlahBarangTextBox.SelectionStart = 0;
            this.jumlahBarangTextBox.ShortcutsEnabled = true;
            this.jumlahBarangTextBox.Size = new System.Drawing.Size(169, 25);
            this.jumlahBarangTextBox.TabIndex = 5;
            this.jumlahBarangTextBox.UseSelectable = true;
            this.jumlahBarangTextBox.WaterMark = "Jumlah";
            this.jumlahBarangTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.jumlahBarangTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // merkTextBox
            // 
            // 
            // 
            // 
            this.merkTextBox.CustomButton.Image = null;
            this.merkTextBox.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.merkTextBox.CustomButton.Name = "";
            this.merkTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.merkTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.merkTextBox.CustomButton.TabIndex = 1;
            this.merkTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.merkTextBox.CustomButton.UseSelectable = true;
            this.merkTextBox.CustomButton.Visible = false;
            this.merkTextBox.Lines = new string[0];
            this.merkTextBox.Location = new System.Drawing.Point(215, 126);
            this.merkTextBox.MaxLength = 32767;
            this.merkTextBox.Name = "merkTextBox";
            this.merkTextBox.PasswordChar = '\0';
            this.merkTextBox.PromptText = "Merk HP/Laptop";
            this.merkTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.merkTextBox.SelectedText = "";
            this.merkTextBox.SelectionLength = 0;
            this.merkTextBox.SelectionStart = 0;
            this.merkTextBox.ShortcutsEnabled = true;
            this.merkTextBox.Size = new System.Drawing.Size(169, 25);
            this.merkTextBox.TabIndex = 4;
            this.merkTextBox.UseSelectable = true;
            this.merkTextBox.WaterMark = "Merk HP/Laptop";
            this.merkTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.merkTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // namaBarangTextBox
            // 
            // 
            // 
            // 
            this.namaBarangTextBox.CustomButton.Image = null;
            this.namaBarangTextBox.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.namaBarangTextBox.CustomButton.Name = "";
            this.namaBarangTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.namaBarangTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.namaBarangTextBox.CustomButton.TabIndex = 1;
            this.namaBarangTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.namaBarangTextBox.CustomButton.UseSelectable = true;
            this.namaBarangTextBox.CustomButton.Visible = false;
            this.namaBarangTextBox.Lines = new string[0];
            this.namaBarangTextBox.Location = new System.Drawing.Point(215, 86);
            this.namaBarangTextBox.MaxLength = 32767;
            this.namaBarangTextBox.Name = "namaBarangTextBox";
            this.namaBarangTextBox.PasswordChar = '\0';
            this.namaBarangTextBox.PromptText = "Nama Barang";
            this.namaBarangTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.namaBarangTextBox.SelectedText = "";
            this.namaBarangTextBox.SelectionLength = 0;
            this.namaBarangTextBox.SelectionStart = 0;
            this.namaBarangTextBox.ShortcutsEnabled = true;
            this.namaBarangTextBox.Size = new System.Drawing.Size(169, 25);
            this.namaBarangTextBox.TabIndex = 3;
            this.namaBarangTextBox.UseSelectable = true;
            this.namaBarangTextBox.WaterMark = "Nama Barang";
            this.namaBarangTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.namaBarangTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // manajemenAkunButton
            // 
            this.manajemenAkunButton.Location = new System.Drawing.Point(588, 31);
            this.manajemenAkunButton.Name = "manajemenAkunButton";
            this.manajemenAkunButton.Size = new System.Drawing.Size(111, 23);
            this.manajemenAkunButton.TabIndex = 2;
            this.manajemenAkunButton.Text = "Manajemen Akun";
            this.manajemenAkunButton.UseSelectable = true;
            this.manajemenAkunButton.Click += new System.EventHandler(this.manajemenAkunButton_Click);
            // 
            // barangKeluarTabPage
            // 
            this.barangKeluarTabPage.Controls.Add(this.logKeluarLabel);
            this.barangKeluarTabPage.Controls.Add(this.keluarkanButton);
            this.barangKeluarTabPage.Controls.Add(this.jumlahKeluarTextBox);
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
            // idBarangKeluarLabel
            // 
            this.idBarangKeluarLabel.AutoSize = true;
            this.idBarangKeluarLabel.Location = new System.Drawing.Point(3, 12);
            this.idBarangKeluarLabel.Name = "idBarangKeluarLabel";
            this.idBarangKeluarLabel.Size = new System.Drawing.Size(70, 19);
            this.idBarangKeluarLabel.TabIndex = 2;
            this.idBarangKeluarLabel.Text = "ID Barang:";
            // 
            // idBarangKeluarTextBox
            // 
            // 
            // 
            // 
            this.idBarangKeluarTextBox.CustomButton.Image = null;
            this.idBarangKeluarTextBox.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.idBarangKeluarTextBox.CustomButton.Name = "";
            this.idBarangKeluarTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.idBarangKeluarTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idBarangKeluarTextBox.CustomButton.TabIndex = 1;
            this.idBarangKeluarTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idBarangKeluarTextBox.CustomButton.UseSelectable = true;
            this.idBarangKeluarTextBox.CustomButton.Visible = false;
            this.idBarangKeluarTextBox.Lines = new string[0];
            this.idBarangKeluarTextBox.Location = new System.Drawing.Point(79, 12);
            this.idBarangKeluarTextBox.MaxLength = 32767;
            this.idBarangKeluarTextBox.Name = "idBarangKeluarTextBox";
            this.idBarangKeluarTextBox.PasswordChar = '\0';
            this.idBarangKeluarTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idBarangKeluarTextBox.SelectedText = "";
            this.idBarangKeluarTextBox.SelectionLength = 0;
            this.idBarangKeluarTextBox.SelectionStart = 0;
            this.idBarangKeluarTextBox.ShortcutsEnabled = true;
            this.idBarangKeluarTextBox.Size = new System.Drawing.Size(195, 23);
            this.idBarangKeluarTextBox.TabIndex = 3;
            this.idBarangKeluarTextBox.UseSelectable = true;
            this.idBarangKeluarTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.idBarangKeluarTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // jumlahKeluarLabel
            // 
            this.jumlahKeluarLabel.AutoSize = true;
            this.jumlahKeluarLabel.Location = new System.Drawing.Point(3, 46);
            this.jumlahKeluarLabel.Name = "jumlahKeluarLabel";
            this.jumlahKeluarLabel.Size = new System.Drawing.Size(53, 19);
            this.jumlahKeluarLabel.TabIndex = 4;
            this.jumlahKeluarLabel.Text = "Jumlah:";
            // 
            // jumlahKeluarTextBox
            // 
            // 
            // 
            // 
            this.jumlahKeluarTextBox.CustomButton.Image = null;
            this.jumlahKeluarTextBox.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.jumlahKeluarTextBox.CustomButton.Name = "";
            this.jumlahKeluarTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.jumlahKeluarTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.jumlahKeluarTextBox.CustomButton.TabIndex = 1;
            this.jumlahKeluarTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.jumlahKeluarTextBox.CustomButton.UseSelectable = true;
            this.jumlahKeluarTextBox.CustomButton.Visible = false;
            this.jumlahKeluarTextBox.Lines = new string[0];
            this.jumlahKeluarTextBox.Location = new System.Drawing.Point(79, 46);
            this.jumlahKeluarTextBox.MaxLength = 32767;
            this.jumlahKeluarTextBox.Name = "jumlahKeluarTextBox";
            this.jumlahKeluarTextBox.PasswordChar = '\0';
            this.jumlahKeluarTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.jumlahKeluarTextBox.SelectedText = "";
            this.jumlahKeluarTextBox.SelectionLength = 0;
            this.jumlahKeluarTextBox.SelectionStart = 0;
            this.jumlahKeluarTextBox.ShortcutsEnabled = true;
            this.jumlahKeluarTextBox.Size = new System.Drawing.Size(195, 23);
            this.jumlahKeluarTextBox.TabIndex = 5;
            this.jumlahKeluarTextBox.UseSelectable = true;
            this.jumlahKeluarTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.jumlahKeluarTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // keluarkanButton
            // 
            this.keluarkanButton.Location = new System.Drawing.Point(3, 75);
            this.keluarkanButton.Name = "keluarkanButton";
            this.keluarkanButton.Size = new System.Drawing.Size(271, 23);
            this.keluarkanButton.TabIndex = 6;
            this.keluarkanButton.Text = "Proses";
            this.keluarkanButton.UseSelectable = true;
            this.keluarkanButton.Click += new System.EventHandler(this.keluarkanButton_Click);
            // 
            // logKeluarLabel
            // 
            this.logKeluarLabel.AutoSize = true;
            this.logKeluarLabel.Location = new System.Drawing.Point(3, 113);
            this.logKeluarLabel.Name = "logKeluarLabel";
            this.logKeluarLabel.Size = new System.Drawing.Size(44, 19);
            this.logKeluarLabel.TabIndex = 7;
            this.logKeluarLabel.Text = "Log: -";
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.manajemenAkunButton);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.logoutButton);
            this.Name = "MainDashboard";
            this.Text = "MainDashboard";
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.barangTabPage.ResumeLayout(false);
            this.barangTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            this.gudangTabPage.ResumeLayout(false);
            this.barangKeluarTabPage.ResumeLayout(false);
            this.barangKeluarTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton logoutButton;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage barangTabPage;
        private MetroFramework.Controls.MetroTabPage gudangTabPage;
        private MetroFramework.Controls.MetroButton loadDataButton;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private MetroFramework.Controls.MetroButton tambahBarangButton;
        private MetroFramework.Controls.MetroComboBox kategoriComboBox;
        private MetroFramework.Controls.MetroTextBox jumlahBarangTextBox;
        private MetroFramework.Controls.MetroTextBox merkTextBox;
        private MetroFramework.Controls.MetroTextBox namaBarangTextBox;
        private MetroFramework.Controls.MetroLabel statusGudangLabel;
        private MetroFramework.Controls.MetroButton manajemenAkunButton;
        private MetroFramework.Controls.MetroTabPage barangKeluarTabPage;
        private MetroFramework.Controls.MetroLabel logKeluarLabel;
        private MetroFramework.Controls.MetroButton keluarkanButton;
        private MetroFramework.Controls.MetroTextBox jumlahKeluarTextBox;
        private MetroFramework.Controls.MetroLabel jumlahKeluarLabel;
        private MetroFramework.Controls.MetroTextBox idBarangKeluarTextBox;
        private MetroFramework.Controls.MetroLabel idBarangKeluarLabel;
    }
}