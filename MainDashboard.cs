using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace clo4konstruksi
{
    public partial class MainDashboard : MetroFramework.Forms.MetroForm
    {
        private LoginService _loginService;
        private Form _loginForm;

        // Metode untuk memperbarui semua teks di form ini
        private void UpdateUITexts()
        {
            var lang = LoginService.Instance.LangManager;

            // Komponen Utama
            logoutButton.Text = lang.Get("LogoutButton");
            manajemenAkunButton.Text = lang.Get("TabAccounts");
            transaksiButton.Text = lang.Get("TransactionButton");
            languageLabel.Text = lang.Get("LanguageLabel");

            // Kontrol di Tab Data Barang
            filterLabel.Text = lang.Get("FilterCategoryLabel");
            sortLabel.Text = lang.Get("SortByLabel");
            sortOrderToggle.Text = lang.Get("SortOrderLabel");
            terapkanFilterButton.Text = lang.Get("ApplyFilterButton");
            if (filterKategoriComboBox.Items.Count > 0)
            {
                filterKategoriComboBox.Items[0] = lang.Get("AllFilter");
            }
        }

        // Metode yang akan berjalan saat toggle di-klik
        private void languageToggle_CheckedChanged(object sender, EventArgs e)
        {
            var langManager = LoginService.Instance.LangManager;

            // Ganti bahasa berdasarkan status toggle
            if (languageToggle.Checked)
            {
                langManager.LoadLanguage("EN"); // ON = English
            }
            else
            {
                langManager.LoadLanguage("ID"); // OFF = Indonesia
            }

            // Panggil metode untuk memperbarui semua teks di UI
            UpdateUITexts();
        }

        public MainDashboard(Form loginForm)
        {
            InitializeComponent();
            _loginService = LoginService.Instance;
            _loginForm = loginForm;
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            // Atur filter dan muat data
            filterKategoriComboBox.SelectedItem = _loginService.ViewConfig.Kategori;
            sortByComboBox.SelectedItem = _loginService.ViewConfig.UrutkanBerdasarkan;
            sortOrderToggle.Checked = _loginService.ViewConfig.Naik;
            LoadAllItems();
            UpdateCapacityStatus();
            UpdateUITexts();

            // Atur visibilitas tombol berdasarkan peran
            manajemenAkunButton.Visible = (LoginService.Instance.LoggedInUser.Role == "SuperAdmin");
        }

        private void LoadAllItems()
        {
            // 1. Ambil semua konfigurasi dari UI
            var config = new FilterSortConfig
            {
                Kategori = filterKategoriComboBox.Text,
                UrutkanBerdasarkan = sortByComboBox.Text,
                Naik = sortOrderToggle.Checked
            };

            // 2. Ambil data yang sudah di-filter dan di-sort dari LoginService
            List<Item> filteredAndSortedItems = _loginService.GetFilteredAndSortedItems(config);

            // 3. Ambil teks pencarian dari searchTextBox
            string searchTerm = searchTextBox.Text.ToLower().Trim();

            // 4. Lakukan pencarian di atas data yang sudah di-filter & sort
            List<Item> finalResult;
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                // Jika kotak pencarian kosong, tampilkan semua hasil filter & sort
                finalResult = filteredAndSortedItems;
            }
            else
            {
                // Jika ada teks pencarian, filter lebih lanjut
                finalResult = filteredAndSortedItems.Where(item =>
                    item.Name.ToLower().Contains(searchTerm) ||
                    item.Merk.ToLower().Contains(searchTerm)
                ).ToList();
            }

            // 5. Tampilkan hasil akhir ke tabel
            itemsDataGridView.DataSource = null;
            itemsDataGridView.DataSource = finalResult;
        }

        private void terapkanFilterButton_Click(object sender, EventArgs e)
        {
            _loginService.ViewConfig.Kategori = filterKategoriComboBox.Text;
            _loginService.ViewConfig.UrutkanBerdasarkan = sortByComboBox.Text;
            _loginService.ViewConfig.Naik = sortOrderToggle.Checked;
            _loginService.SaveViewConfig();
            LoadAllItems();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            // ... logika logout ...
            if (MessageBox.Show("Anda yakin?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _loginForm.Show();
                this.Close();
            }
        }

        private void manajemenAkunButton_Click(object sender, EventArgs e)
        {
            ManajemenAkunForm form = new ManajemenAkunForm(_loginForm);
            form.Show();
            this.Close();
        }

        // Tombol BARU untuk navigasi
        private void transaksiButton_Click(object sender, EventArgs e)
        {
            TransaksiBarangForm form = new TransaksiBarangForm(_loginForm);
            form.Show();
            this.Close();
        }

        private void UpdateCapacityStatus()
        {
            // Memanggil metode GetWarehouseStatus dan memberikan LanguageManager sebagai parameter
            statusGudangLabel.Text = LoginService.Instance.InvManager.GetWarehouseStatus(LoginService.Instance.LangManager);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            // Setiap kali teks di kotak pencarian berubah, panggil metode utama untuk memperbarui tabel.
            LoadAllItems();
        }
    }
}