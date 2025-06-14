namespace clo4konstruksi
{
    partial class TransaksiBarangForm
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.barangMasukTabPage = new MetroFramework.Controls.MetroTabPage();
            this.jenisLabel = new MetroFramework.Controls.MetroLabel();
            this.jumlahLabel = new MetroFramework.Controls.MetroLabel();
            this.merkLabel = new MetroFramework.Controls.MetroLabel();
            this.TipeBarangLabel = new MetroFramework.Controls.MetroLabel();
            this.inboundTitleLabel = new MetroFramework.Controls.MetroLabel();
            this.tambahBarangButton = new MetroFramework.Controls.MetroButton();
            this.kategoriComboBox = new MetroFramework.Controls.MetroComboBox();
            this.jumlahBarangTextBox = new MetroFramework.Controls.MetroTextBox();
            this.merkTextBox = new MetroFramework.Controls.MetroTextBox();
            this.namaBarangTextBox = new MetroFramework.Controls.MetroTextBox();
            this.barangKeluarTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.logKeluarLabel = new MetroFramework.Controls.MetroLabel();
            this.keluarkanButton = new MetroFramework.Controls.MetroButton();
            this.jumlahKeluarTextBox = new MetroFramework.Controls.MetroTextBox();
            this.jumlahKeluarLabel = new MetroFramework.Controls.MetroLabel();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.kembaliButton = new MetroFramework.Controls.MetroButton();
            this.searchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.selectionInfoLabel = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.barangMasukTabPage.SuspendLayout();
            this.barangKeluarTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.barangMasukTabPage);
            this.metroTabControl1.Controls.Add(this.barangKeluarTabPage);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 195);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(760, 235);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // barangMasukTabPage
            // 
            this.barangMasukTabPage.Controls.Add(this.jenisLabel);
            this.barangMasukTabPage.Controls.Add(this.jumlahLabel);
            this.barangMasukTabPage.Controls.Add(this.merkLabel);
            this.barangMasukTabPage.Controls.Add(this.TipeBarangLabel);
            this.barangMasukTabPage.Controls.Add(this.inboundTitleLabel);
            this.barangMasukTabPage.Controls.Add(this.tambahBarangButton);
            this.barangMasukTabPage.Controls.Add(this.kategoriComboBox);
            this.barangMasukTabPage.Controls.Add(this.jumlahBarangTextBox);
            this.barangMasukTabPage.Controls.Add(this.merkTextBox);
            this.barangMasukTabPage.Controls.Add(this.namaBarangTextBox);
            this.barangMasukTabPage.HorizontalScrollbarBarColor = true;
            this.barangMasukTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.barangMasukTabPage.HorizontalScrollbarSize = 10;
            this.barangMasukTabPage.Location = new System.Drawing.Point(4, 38);
            this.barangMasukTabPage.Name = "barangMasukTabPage";
            this.barangMasukTabPage.Size = new System.Drawing.Size(752, 193);
            this.barangMasukTabPage.TabIndex = 0;
            this.barangMasukTabPage.Text = "Barang Masuk";
            this.barangMasukTabPage.VerticalScrollbarBarColor = true;
            this.barangMasukTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.barangMasukTabPage.VerticalScrollbarSize = 10;
            // 
            // jenisLabel
            // 
            this.jenisLabel.AutoSize = true;
            this.jenisLabel.Location = new System.Drawing.Point(418, 35);
            this.jenisLabel.Name = "jenisLabel";
            this.jenisLabel.Size = new System.Drawing.Size(39, 19);
            this.jenisLabel.TabIndex = 22;
            this.jenisLabel.Text = "Jenis:";
            // 
            // jumlahLabel
            // 
            this.jumlahLabel.AutoSize = true;
            this.jumlahLabel.Location = new System.Drawing.Point(117, 112);
            this.jumlahLabel.Name = "jumlahLabel";
            this.jumlahLabel.Size = new System.Drawing.Size(53, 19);
            this.jumlahLabel.TabIndex = 21;
            this.jumlahLabel.Text = "Jumlah:";
            // 
            // merkLabel
            // 
            this.merkLabel.AutoSize = true;
            this.merkLabel.Location = new System.Drawing.Point(133, 35);
            this.merkLabel.Name = "merkLabel";
            this.merkLabel.Size = new System.Drawing.Size(42, 19);
            this.merkLabel.TabIndex = 20;
            this.merkLabel.Text = "Merk:";
            // 
            // TipeBarangLabel
            // 
            this.TipeBarangLabel.AutoSize = true;
            this.TipeBarangLabel.Location = new System.Drawing.Point(133, 72);
            this.TipeBarangLabel.Name = "TipeBarangLabel";
            this.TipeBarangLabel.Size = new System.Drawing.Size(37, 19);
            this.TipeBarangLabel.TabIndex = 19;
            this.TipeBarangLabel.Text = "Tipe:";
            // 
            // inboundTitleLabel
            // 
            this.inboundTitleLabel.AutoSize = true;
            this.inboundTitleLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.inboundTitleLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.inboundTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.inboundTitleLabel.Name = "inboundTitleLabel";
            this.inboundTitleLabel.Size = new System.Drawing.Size(134, 25);
            this.inboundTitleLabel.TabIndex = 18;
            this.inboundTitleLabel.Text = "Barang Masuk";
            // 
            // tambahBarangButton
            // 
            this.tambahBarangButton.Location = new System.Drawing.Point(463, 72);
            this.tambahBarangButton.Name = "tambahBarangButton";
            this.tambahBarangButton.Size = new System.Drawing.Size(121, 25);
            this.tambahBarangButton.TabIndex = 17;
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
            this.kategoriComboBox.Location = new System.Drawing.Point(463, 35);
            this.kategoriComboBox.Name = "kategoriComboBox";
            this.kategoriComboBox.Size = new System.Drawing.Size(121, 29);
            this.kategoriComboBox.TabIndex = 16;
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
            this.jumlahBarangTextBox.Location = new System.Drawing.Point(181, 112);
            this.jumlahBarangTextBox.MaxLength = 32767;
            this.jumlahBarangTextBox.Name = "jumlahBarangTextBox";
            this.jumlahBarangTextBox.PasswordChar = '\0';
            this.jumlahBarangTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.jumlahBarangTextBox.SelectedText = "";
            this.jumlahBarangTextBox.SelectionLength = 0;
            this.jumlahBarangTextBox.SelectionStart = 0;
            this.jumlahBarangTextBox.ShortcutsEnabled = true;
            this.jumlahBarangTextBox.Size = new System.Drawing.Size(169, 25);
            this.jumlahBarangTextBox.TabIndex = 15;
            this.jumlahBarangTextBox.UseSelectable = true;
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
            this.merkTextBox.Location = new System.Drawing.Point(181, 35);
            this.merkTextBox.MaxLength = 32767;
            this.merkTextBox.Name = "merkTextBox";
            this.merkTextBox.PasswordChar = '\0';
            this.merkTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.merkTextBox.SelectedText = "";
            this.merkTextBox.SelectionLength = 0;
            this.merkTextBox.SelectionStart = 0;
            this.merkTextBox.ShortcutsEnabled = true;
            this.merkTextBox.Size = new System.Drawing.Size(169, 25);
            this.merkTextBox.TabIndex = 14;
            this.merkTextBox.UseSelectable = true;
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
            this.namaBarangTextBox.Location = new System.Drawing.Point(181, 72);
            this.namaBarangTextBox.MaxLength = 32767;
            this.namaBarangTextBox.Name = "namaBarangTextBox";
            this.namaBarangTextBox.PasswordChar = '\0';
            this.namaBarangTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.namaBarangTextBox.SelectedText = "";
            this.namaBarangTextBox.SelectionLength = 0;
            this.namaBarangTextBox.SelectionStart = 0;
            this.namaBarangTextBox.ShortcutsEnabled = true;
            this.namaBarangTextBox.Size = new System.Drawing.Size(169, 25);
            this.namaBarangTextBox.TabIndex = 13;
            this.namaBarangTextBox.UseSelectable = true;
            this.namaBarangTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.namaBarangTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // barangKeluarTabPage
            // 
            this.barangKeluarTabPage.Controls.Add(this.selectionInfoLabel);
            this.barangKeluarTabPage.Controls.Add(this.metroLabel6);
            this.barangKeluarTabPage.Controls.Add(this.logKeluarLabel);
            this.barangKeluarTabPage.Controls.Add(this.keluarkanButton);
            this.barangKeluarTabPage.Controls.Add(this.jumlahKeluarTextBox);
            this.barangKeluarTabPage.Controls.Add(this.jumlahKeluarLabel);
            this.barangKeluarTabPage.HorizontalScrollbarBarColor = true;
            this.barangKeluarTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.barangKeluarTabPage.HorizontalScrollbarSize = 10;
            this.barangKeluarTabPage.Location = new System.Drawing.Point(4, 38);
            this.barangKeluarTabPage.Name = "barangKeluarTabPage";
            this.barangKeluarTabPage.Size = new System.Drawing.Size(752, 193);
            this.barangKeluarTabPage.TabIndex = 1;
            this.barangKeluarTabPage.Text = "Barang Keluar";
            this.barangKeluarTabPage.VerticalScrollbarBarColor = true;
            this.barangKeluarTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.barangKeluarTabPage.VerticalScrollbarSize = 10;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(3, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(133, 25);
            this.metroLabel6.TabIndex = 16;
            this.metroLabel6.Text = "Barang Keluar";
            // 
            // logKeluarLabel
            // 
            this.logKeluarLabel.AutoSize = true;
            this.logKeluarLabel.Location = new System.Drawing.Point(242, 127);
            this.logKeluarLabel.Name = "logKeluarLabel";
            this.logKeluarLabel.Size = new System.Drawing.Size(88, 19);
            this.logKeluarLabel.TabIndex = 15;
            this.logKeluarLabel.Text = "Keterangan: -";
            // 
            // keluarkanButton
            // 
            this.keluarkanButton.Location = new System.Drawing.Point(242, 89);
            this.keluarkanButton.Name = "keluarkanButton";
            this.keluarkanButton.Size = new System.Drawing.Size(271, 23);
            this.keluarkanButton.TabIndex = 14;
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
            this.jumlahKeluarTextBox.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.jumlahKeluarTextBox.CustomButton.Name = "";
            this.jumlahKeluarTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.jumlahKeluarTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.jumlahKeluarTextBox.CustomButton.TabIndex = 1;
            this.jumlahKeluarTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.jumlahKeluarTextBox.CustomButton.UseSelectable = true;
            this.jumlahKeluarTextBox.CustomButton.Visible = false;
            this.jumlahKeluarTextBox.Lines = new string[0];
            this.jumlahKeluarTextBox.Location = new System.Drawing.Point(318, 60);
            this.jumlahKeluarTextBox.MaxLength = 32767;
            this.jumlahKeluarTextBox.Name = "jumlahKeluarTextBox";
            this.jumlahKeluarTextBox.PasswordChar = '\0';
            this.jumlahKeluarTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.jumlahKeluarTextBox.SelectedText = "";
            this.jumlahKeluarTextBox.SelectionLength = 0;
            this.jumlahKeluarTextBox.SelectionStart = 0;
            this.jumlahKeluarTextBox.ShortcutsEnabled = true;
            this.jumlahKeluarTextBox.Size = new System.Drawing.Size(195, 23);
            this.jumlahKeluarTextBox.TabIndex = 13;
            this.jumlahKeluarTextBox.UseSelectable = true;
            this.jumlahKeluarTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.jumlahKeluarTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // jumlahKeluarLabel
            // 
            this.jumlahKeluarLabel.AutoSize = true;
            this.jumlahKeluarLabel.Location = new System.Drawing.Point(242, 60);
            this.jumlahKeluarLabel.Name = "jumlahKeluarLabel";
            this.jumlahKeluarLabel.Size = new System.Drawing.Size(53, 19);
            this.jumlahKeluarLabel.TabIndex = 12;
            this.jumlahKeluarLabel.Text = "Jumlah:";
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.AllowUserToAddRows = false;
            this.itemsDataGridView.AllowUserToDeleteRows = false;
            this.itemsDataGridView.AllowUserToOrderColumns = true;
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemsDataGridView.Location = new System.Drawing.Point(20, 60);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.ReadOnly = true;
            this.itemsDataGridView.Size = new System.Drawing.Size(760, 100);
            this.itemsDataGridView.TabIndex = 1;
            this.itemsDataGridView.SelectionChanged += new System.EventHandler(this.itemsDataGridView_SelectionChanged);
            // 
            // kembaliButton
            // 
            this.kembaliButton.Location = new System.Drawing.Point(630, 29);
            this.kembaliButton.Name = "kembaliButton";
            this.kembaliButton.Size = new System.Drawing.Size(150, 25);
            this.kembaliButton.TabIndex = 2;
            this.kembaliButton.Text = "Kembali ke Dashboard";
            this.kembaliButton.UseSelectable = true;
            this.kembaliButton.Click += new System.EventHandler(this.kembaliButton_Click);
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
            this.searchTextBox.Location = new System.Drawing.Point(20, 166);
            this.searchTextBox.MaxLength = 32767;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PromptText = "Cari berdasarkan Nama atau Merk...";
            this.searchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.SelectionLength = 0;
            this.searchTextBox.SelectionStart = 0;
            this.searchTextBox.ShortcutsEnabled = true;
            this.searchTextBox.Size = new System.Drawing.Size(205, 23);
            this.searchTextBox.TabIndex = 21;
            this.searchTextBox.UseSelectable = true;
            this.searchTextBox.WaterMark = "Cari berdasarkan Nama atau Merk...";
            this.searchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // selectionInfoLabel
            // 
            this.selectionInfoLabel.AutoSize = true;
            this.selectionInfoLabel.Location = new System.Drawing.Point(242, 35);
            this.selectionInfoLabel.Name = "selectionInfoLabel";
            this.selectionInfoLabel.Size = new System.Drawing.Size(64, 25);
            this.selectionInfoLabel.TabIndex = 17;
            this.selectionInfoLabel.Text = "Info: -";
            // 
            // TransaksiBarangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.kembaliButton);
            this.Controls.Add(this.itemsDataGridView);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "TransaksiBarangForm";
            this.Text = "TransaksiBarangForm";
            this.Load += new System.EventHandler(this.TransaksiBarangForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.barangMasukTabPage.ResumeLayout(false);
            this.barangMasukTabPage.PerformLayout();
            this.barangKeluarTabPage.ResumeLayout(false);
            this.barangKeluarTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage barangMasukTabPage;
        private MetroFramework.Controls.MetroTabPage barangKeluarTabPage;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private MetroFramework.Controls.MetroButton kembaliButton;
        private MetroFramework.Controls.MetroLabel jenisLabel;
        private MetroFramework.Controls.MetroLabel jumlahLabel;
        private MetroFramework.Controls.MetroLabel merkLabel;
        private MetroFramework.Controls.MetroLabel TipeBarangLabel;
        private MetroFramework.Controls.MetroLabel inboundTitleLabel;
        private MetroFramework.Controls.MetroButton tambahBarangButton;
        private MetroFramework.Controls.MetroComboBox kategoriComboBox;
        private MetroFramework.Controls.MetroTextBox jumlahBarangTextBox;
        private MetroFramework.Controls.MetroTextBox merkTextBox;
        private MetroFramework.Controls.MetroTextBox namaBarangTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel logKeluarLabel;
        private MetroFramework.Controls.MetroButton keluarkanButton;
        private MetroFramework.Controls.MetroTextBox jumlahKeluarTextBox;
        private MetroFramework.Controls.MetroLabel jumlahKeluarLabel;
        private MetroFramework.Controls.MetroTextBox searchTextBox;
        private MetroFramework.Controls.MetroLabel selectionInfoLabel;
    }
}