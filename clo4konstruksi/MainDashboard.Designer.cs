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
            this.manajemenAkunButton = new MetroFramework.Controls.MetroButton();
            this.languageToggle = new MetroFramework.Controls.MetroToggle();
            this.languageLabel = new MetroFramework.Controls.MetroLabel();
            this.terapkanFilterButton = new MetroFramework.Controls.MetroButton();
            this.sortOrderToggle = new MetroFramework.Controls.MetroToggle();
            this.sortByComboBox = new MetroFramework.Controls.MetroComboBox();
            this.sortLabel = new MetroFramework.Controls.MetroLabel();
            this.filterKategoriComboBox = new MetroFramework.Controls.MetroComboBox();
            this.filterLabel = new MetroFramework.Controls.MetroLabel();
            this.statusGudangLabel = new MetroFramework.Controls.MetroLabel();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.transaksiButton = new MetroFramework.Controls.MetroButton();
            this.searchTextBox = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
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
            // languageToggle
            // 
            this.languageToggle.AutoSize = true;
            this.languageToggle.Location = new System.Drawing.Point(480, 37);
            this.languageToggle.Name = "languageToggle";
            this.languageToggle.Size = new System.Drawing.Size(80, 17);
            this.languageToggle.TabIndex = 3;
            this.languageToggle.Text = "Off";
            this.languageToggle.UseSelectable = true;
            this.languageToggle.CheckedChanged += new System.EventHandler(this.languageToggle_CheckedChanged);
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(391, 35);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(64, 19);
            this.languageLabel.TabIndex = 4;
            this.languageLabel.Text = "Indonesia";
            // 
            // terapkanFilterButton
            // 
            this.terapkanFilterButton.Location = new System.Drawing.Point(437, 374);
            this.terapkanFilterButton.Name = "terapkanFilterButton";
            this.terapkanFilterButton.Size = new System.Drawing.Size(75, 23);
            this.terapkanFilterButton.TabIndex = 18;
            this.terapkanFilterButton.Text = "Terapkan";
            this.terapkanFilterButton.UseSelectable = true;
            this.terapkanFilterButton.Click += new System.EventHandler(this.terapkanFilterButton_Click);
            // 
            // sortOrderToggle
            // 
            this.sortOrderToggle.AutoSize = true;
            this.sortOrderToggle.Location = new System.Drawing.Point(310, 374);
            this.sortOrderToggle.Name = "sortOrderToggle";
            this.sortOrderToggle.Size = new System.Drawing.Size(80, 17);
            this.sortOrderToggle.TabIndex = 17;
            this.sortOrderToggle.Text = "Off";
            this.sortOrderToggle.UseSelectable = true;
            // 
            // sortByComboBox
            // 
            this.sortByComboBox.FormattingEnabled = true;
            this.sortByComboBox.ItemHeight = 23;
            this.sortByComboBox.Items.AddRange(new object[] {
            "Name",
            "Merk",
            "Quantity",
            "TanggalMasuk"});
            this.sortByComboBox.Location = new System.Drawing.Point(391, 336);
            this.sortByComboBox.Name = "sortByComboBox";
            this.sortByComboBox.Size = new System.Drawing.Size(121, 29);
            this.sortByComboBox.TabIndex = 16;
            this.sortByComboBox.UseSelectable = true;
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.Location = new System.Drawing.Point(291, 336);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(57, 19);
            this.sortLabel.TabIndex = 15;
            this.sortLabel.Text = "Urutkan:";
            // 
            // filterKategoriComboBox
            // 
            this.filterKategoriComboBox.FormattingEnabled = true;
            this.filterKategoriComboBox.ItemHeight = 23;
            this.filterKategoriComboBox.Items.AddRange(new object[] {
            "(Semua)",
            "HP",
            "Laptop"});
            this.filterKategoriComboBox.Location = new System.Drawing.Point(391, 292);
            this.filterKategoriComboBox.Name = "filterKategoriComboBox";
            this.filterKategoriComboBox.Size = new System.Drawing.Size(121, 29);
            this.filterKategoriComboBox.TabIndex = 14;
            this.filterKategoriComboBox.UseSelectable = true;
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(291, 292);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(94, 19);
            this.filterLabel.TabIndex = 13;
            this.filterLabel.Text = "Filter Kategori:";
            // 
            // statusGudangLabel
            // 
            this.statusGudangLabel.AutoSize = true;
            this.statusGudangLabel.Location = new System.Drawing.Point(23, 237);
            this.statusGudangLabel.Name = "statusGudangLabel";
            this.statusGudangLabel.Size = new System.Drawing.Size(106, 19);
            this.statusGudangLabel.TabIndex = 12;
            this.statusGudangLabel.Text = "Status Gudang: -";
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.AllowUserToAddRows = false;
            this.itemsDataGridView.AllowUserToDeleteRows = false;
            this.itemsDataGridView.AllowUserToOrderColumns = true;
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Location = new System.Drawing.Point(24, 77);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.ReadOnly = true;
            this.itemsDataGridView.Size = new System.Drawing.Size(752, 150);
            this.itemsDataGridView.TabIndex = 11;
            // 
            // transaksiButton
            // 
            this.transaksiButton.Location = new System.Drawing.Point(555, 233);
            this.transaksiButton.Name = "transaksiButton";
            this.transaksiButton.Size = new System.Drawing.Size(221, 23);
            this.transaksiButton.TabIndex = 19;
            this.transaksiButton.Text = "Buka Transaksi Barang";
            this.transaksiButton.UseSelectable = true;
            this.transaksiButton.Click += new System.EventHandler(this.transaksiButton_Click);
            // 
            // searchTextBox
            // 
            // 
            // 
            // 
            this.searchTextBox.CustomButton.Image = null;
            this.searchTextBox.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.searchTextBox.CustomButton.Name = "";
            this.searchTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchTextBox.CustomButton.TabIndex = 1;
            this.searchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchTextBox.CustomButton.UseSelectable = true;
            this.searchTextBox.CustomButton.Visible = false;
            this.searchTextBox.Lines = new string[0];
            this.searchTextBox.Location = new System.Drawing.Point(344, 233);
            this.searchTextBox.MaxLength = 32767;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.SelectionLength = 0;
            this.searchTextBox.SelectionStart = 0;
            this.searchTextBox.ShortcutsEnabled = true;
            this.searchTextBox.Size = new System.Drawing.Size(205, 23);
            this.searchTextBox.TabIndex = 20;
            this.searchTextBox.UseSelectable = true;
            this.searchTextBox.WaterMark = "Cari berdasarkan Nama atau Merk...";
            this.searchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.transaksiButton);
            this.Controls.Add(this.terapkanFilterButton);
            this.Controls.Add(this.sortOrderToggle);
            this.Controls.Add(this.sortByComboBox);
            this.Controls.Add(this.sortLabel);
            this.Controls.Add(this.filterKategoriComboBox);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.statusGudangLabel);
            this.Controls.Add(this.itemsDataGridView);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.languageToggle);
            this.Controls.Add(this.manajemenAkunButton);
            this.Controls.Add(this.logoutButton);
            this.Name = "MainDashboard";
            this.Text = "MainDashboard";
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton logoutButton;
        private MetroFramework.Controls.MetroButton manajemenAkunButton;
        private MetroFramework.Controls.MetroToggle languageToggle;
        private MetroFramework.Controls.MetroLabel languageLabel;
        private MetroFramework.Controls.MetroButton terapkanFilterButton;
        private MetroFramework.Controls.MetroToggle sortOrderToggle;
        private MetroFramework.Controls.MetroComboBox sortByComboBox;
        private MetroFramework.Controls.MetroLabel sortLabel;
        private MetroFramework.Controls.MetroComboBox filterKategoriComboBox;
        private MetroFramework.Controls.MetroLabel filterLabel;
        private MetroFramework.Controls.MetroLabel statusGudangLabel;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private MetroFramework.Controls.MetroButton transaksiButton;
        private MetroFramework.Controls.MetroTextBox searchTextBox;
    }
}