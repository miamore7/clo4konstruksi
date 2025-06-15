using System;
using System.Collections.Generic;
using System.Linq;
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

            // Panggil ini untuk mengatur teks awal pada label informasi
            itemsDataGridView_SelectionChanged(null, null);
        }

        // --- Logika Umum & Navigasi ---
        private void kembaliButton_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = new MainDashboard(_loginForm);
            dashboard.Show();
            this.Close();
        }

        // Di dalam file TransaksiBarangForm.cs
        private void LoadAllItems()
        {
            // 1. Ambil semua item dari service
            List<Item> allItems = _loginService.GetItems();

            // 2. Ambil teks pencarian dari searchTextBox
            string searchTerm = searchTextBox.Text.ToLower().Trim();

            // 3. Lakukan pencarian jika ada input
            List<Item> finalResult;
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                // Jika kotak pencarian kosong, tampilkan semua item
                finalResult = allItems;
            }
            else
            {
                // Jika ada teks pencarian, filter item
                finalResult = allItems.Where(item =>
                    item.Name.ToLower().Contains(searchTerm) ||
                    item.Merk.ToLower().Contains(searchTerm)
                ).ToList();
            }

            // 4. Tampilkan hasil akhir ke tabel
            itemsDataGridView.DataSource = null;
            itemsDataGridView.DataSource = finalResult;
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
            var lang = LoginService.Instance.LangManager;

            // 1. Pastikan ada baris yang dipilih di tabel
            if (itemsDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih barang di tabel terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Ambil objek 'Item' dari baris yang dipilih
                Item selectedItem = itemsDataGridView.CurrentRow.DataBoundItem as Item;
                if (selectedItem == null) return;

                // Validasi jumlah yang akan dikeluarkan
                if (!int.TryParse(jumlahKeluarTextBox.Text, out int jumlah) || jumlah <= 0)
                {
                    throw new ArgumentException(lang.Get("Error_JumlahInvalid"));
                }

                // Proses pengeluaran barang menggunakan item yang sudah dipilih
                int stokLama = selectedItem.Quantity;
                LoginService.Instance.BarangKeluarMgr.KeluarkanBarang(selectedItem, jumlah);

                // Simpan dan update UI
                LoginService.Instance.SaveItems();
                LoadAllItems();

                // Menggunakan 'selectedItem' dan 'LogPrefix' yang benar
                logKeluarLabel.Text = $"{lang.Get("LogPrefix")} {lang.Format("SuccessMessage", jumlah, selectedItem.Name, stokLama, selectedItem.Quantity)}";
            }
            catch (Exception ex)
            {
                // Menggunakan 'LogPrefix' yang benar
                logKeluarLabel.Text = $"{lang.Get("LogPrefix")} {lang.Get("Error_General")} {ex.Message}";
            }
            finally
            {
                // Hanya kosongkan input jumlah
                jumlahKeluarTextBox.Clear();
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            // Setiap kali teks berubah, panggil LoadAllItems untuk memfilter tabel
            LoadAllItems();
        }

        private void itemsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var lang = LoginService.Instance.LangManager;

            if (itemsDataGridView.CurrentRow != null && itemsDataGridView.CurrentRow.DataBoundItem is Item selectedItem)
            {
                // PERUBAHAN DI SINI: Memberikan selectedItem.Merk sebagai parameter pertama
                selectionInfoLabel.Text = lang.Format("SelectedItemInfo", selectedItem.Merk, selectedItem.Name, selectedItem.Quantity);
            }
            else
            {
                selectionInfoLabel.Text = lang.Get("NoItemSelected");
            }
        }
    }
}