using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace clo4konstruksi
{
    public partial class TransaksiBarangForm : MetroFramework.Forms.MetroForm
    {
        private LoginService _loginService;
        private Form _loginForm;

        private void UpdateUITexts()
        {
            var lang = LoginService.Instance.LangManager;

            // --- Tombol Utama ---
            kembaliButton.Text = lang.Get("BackButton");

            // --- Judul Tab ---
            barangMasukTabPage.Text = lang.Get("TabInbound");
            barangKeluarTabPage.Text = lang.Get("TabOutbound");

            // --- Kontrol di Tab Barang Masuk ---
            // (Ganti nama-nama label ini jika berbeda di desainer Anda)
            // inboundTitleLabel.Text = lang.Get("InboundGoodsTitle"); 
            tambahBarangButton.Text = lang.Get("AddItemButton");

            // --- Kontrol di Tab Barang Keluar ---
            idBarangKeluarLabel.Text = lang.Get("InputID");
            jumlahKeluarLabel.Text = lang.Get("InputJumlah");
            keluarkanButton.Text = lang.Get("IssueItemButton");
        }

        public TransaksiBarangForm(Form loginForm)
        {
            InitializeComponent();
            _loginService = LoginService.Instance;
            _loginForm = loginForm;
        }

        private void TransaksiBarangForm_Load(object sender, EventArgs e)
        {
            // Saat form dibuka, langsung muat data barang ke tabel
            LoadAllItems();
            UpdateUITexts();
        }

        // --- Logika Umum & Navigasi ---
        private void kembaliButton_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = new MainDashboard(_loginForm);
            dashboard.Show();
            this.Close();
        }

        private void LoadAllItems()
        {
            itemsDataGridView.DataSource = null;
            itemsDataGridView.DataSource = _loginService.GetItems();
        }

        // --- Logika untuk Tab Barang Masuk ---
        private void tambahBarangButton_Click(object sender, EventArgs e)
        {
            // (Ini adalah kode yang sama dari MainDashboard sebelumnya)
            if (string.IsNullOrWhiteSpace(namaBarangTextBox.Text) || string.IsNullOrWhiteSpace(merkTextBox.Text) || string.IsNullOrWhiteSpace(jumlahBarangTextBox.Text) || kategoriComboBox.SelectedItem == null) { MessageBox.Show("Semua kolom harus diisi."); return; }
            if (!int.TryParse(jumlahBarangTextBox.Text, out int jumlah) || jumlah <= 0) { MessageBox.Show("Jumlah harus angka positif."); return; }
            var newItem = new Item { Name = namaBarangTextBox.Text, Merk = merkTextBox.Text, Category = kategoriComboBox.SelectedItem.ToString(), Quantity = jumlah };
            if (LoginService.Instance.InvManager.CanAddItem(newItem, out string errorMessage))
            {
                LoginService.Instance.InvManager.AddItem(newItem);
                LoginService.Instance.SaveItems();
                MessageBox.Show("Barang berhasil ditambahkan/diupdate.");
                namaBarangTextBox.Clear(); merkTextBox.Clear(); jumlahBarangTextBox.Clear();
                LoadAllItems();
            }
            else { MessageBox.Show(errorMessage, "Kapasitas Penuh"); }
        }

        // --- Logika untuk Tab Barang Keluar ---
        private void keluarkanButton_Click(object sender, EventArgs e)
        {
            // (Ini adalah kode yang sama dari MainDashboard sebelumnya)
            var lang = LoginService.Instance.LangManager;
            try
            {
                if (string.IsNullOrWhiteSpace(idBarangKeluarTextBox.Text)) throw new ArgumentException(lang.Get("Error_IDKosong"));
                if (!int.TryParse(jumlahKeluarTextBox.Text, out int jumlah) || jumlah <= 0) throw new ArgumentException(lang.Get("Error_JumlahInvalid"));
                string idToFind = idBarangKeluarTextBox.Text;
                var barang = LoginService.Instance.GetItems().Find(b => b.Id.Equals(idToFind, StringComparison.OrdinalIgnoreCase));
                if (barang == null) throw new KeyNotFoundException(lang.Format("Error_BarangTidakDitemukan", idToFind));
                int stokLama = barang.Quantity;
                LoginService.Instance.BarangKeluarMgr.KeluarkanBarang(barang, jumlah);
                LoginService.Instance.SaveItems();
                LoadAllItems();
                logKeluarLabel.Text = $"Log: {lang.Format("SuccessMessage", jumlah, barang.Name, stokLama, barang.Quantity)}";
            }
            catch (Exception ex) { logKeluarLabel.Text = $"Log: {lang.Get("Error_General")} {ex.Message}"; }
            finally { idBarangKeluarTextBox.Clear(); jumlahKeluarTextBox.Clear(); }
        }
    }
}