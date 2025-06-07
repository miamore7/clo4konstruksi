using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace clo4konstruksi
{
    public partial class MainDashboard : MetroFramework.Forms.MetroForm
    {
        private LoginService _loginService;
        private Form _loginForm;

        public MainDashboard(Form loginForm)
        {
            InitializeComponent();
            _loginService = LoginService.Instance;
            _loginForm = loginForm;
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            // 1. Atur tampilan filter & sort dari konfigurasi yang tersimpan
            filterKategoriComboBox.SelectedItem = _loginService.ViewConfig.Kategori;
            sortByComboBox.SelectedItem = _loginService.ViewConfig.UrutkanBerdasarkan;
            sortOrderToggle.Checked = _loginService.ViewConfig.Naik;

            // 2. Muat data awal untuk tabel dan status gudang
            LoadAllItems();
            UpdateCapacityStatus();

            // 3. Atur hak akses untuk tombol Manajemen Akun (hanya terlihat oleh SuperAdmin)
            manajemenAkunButton.Visible = (LoginService.Instance.LoggedInUser.Role == "SuperAdmin");
        }

        // --- Tombol Navigasi Utama ---

        private void logoutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda yakin ingin keluar?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginService.Instance.Logout();
                _loginForm.Show();
                this.Close();
            }
        }

        private void manajemenAkunButton_Click(object sender, EventArgs e)
        {
            // Buka form manajemen akun dan tutup form ini
            ManajemenAkunForm formAkun = new ManajemenAkunForm(_loginForm);
            formAkun.Show();
            this.Close();
        }

        // --- Logika untuk Tab Data Barang ---

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            LoadAllItems();
        }

        private void LoadAllItems()
        {
            var config = new FilterSortConfig
            {
                Kategori = filterKategoriComboBox.Text,
                UrutkanBerdasarkan = sortByComboBox.Text,
                Naik = sortOrderToggle.Checked
            };
            itemsDataGridView.DataSource = null;
            itemsDataGridView.DataSource = _loginService.GetFilteredAndSortedItems(config);
        }

        // --- Logika untuk Tab Barang Masuk (dulu Operasi Gudang) ---

        private void UpdateCapacityStatus()
        {
            // Pastikan label ini ada di tab "Data Barang" atau di luar tab
            statusGudangLabel.Text = LoginService.Instance.InvManager.GetWarehouseStatus();
        }

        private void tambahBarangButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(namaBarangTextBox.Text) || string.IsNullOrWhiteSpace(merkTextBox.Text) || string.IsNullOrWhiteSpace(jumlahBarangTextBox.Text) || kategoriComboBox.SelectedItem == null)
            {
                MessageBox.Show("Semua kolom harus diisi.");
                return;
            }
            if (!int.TryParse(jumlahBarangTextBox.Text, out int jumlah) || jumlah <= 0)
            {
                MessageBox.Show("Jumlah harus angka positif.");
                return;
            }

            var newItem = new Item { Name = namaBarangTextBox.Text, Merk = merkTextBox.Text, Category = kategoriComboBox.SelectedItem.ToString(), Quantity = jumlah };

            if (LoginService.Instance.InvManager.CanAddItem(newItem, out string errorMessage))
            {
                LoginService.Instance.InvManager.AddItem(newItem);
                LoginService.Instance.SaveItems();
                MessageBox.Show("Barang berhasil ditambahkan/diupdate.");

                namaBarangTextBox.Clear();
                merkTextBox.Clear();
                jumlahBarangTextBox.Clear();

                LoadAllItems();
                UpdateCapacityStatus();
            }
            else
            {
                MessageBox.Show(errorMessage, "Kapasitas Penuh");
            }
        }

        private void keluarkanButton_Click(object sender, EventArgs e)
        {
            var lang = LoginService.Instance.LangManager;
            try
            {
                if (string.IsNullOrWhiteSpace(idBarangKeluarTextBox.Text))
                {
                    throw new ArgumentException(lang.Get("Error_IDKosong"));
                }
                if (!int.TryParse(jumlahKeluarTextBox.Text, out int jumlah) || jumlah <= 0)
                {
                    throw new ArgumentException(lang.Get("Error_JumlahInvalid"));
                }

                string idToFind = idBarangKeluarTextBox.Text;
                var barang = LoginService.Instance.GetItems().Find(b => b.Id.Equals(idToFind, StringComparison.OrdinalIgnoreCase));

                if (barang == null)
                {
                    throw new KeyNotFoundException(lang.Format("Error_BarangTidakDitemukan", idToFind));
                }

                int stokLama = barang.Quantity;
                LoginService.Instance.BarangKeluarMgr.KeluarkanBarang(barang, jumlah);

                // Simpan perubahan dan update semua tampilan
                LoginService.Instance.SaveItems();
                LoadAllItems();
                UpdateCapacityStatus();

                logKeluarLabel.Text = $"Log: {lang.Format("SuccessMessage", jumlah, barang.Name, stokLama, barang.Quantity)}";
            }
            catch (Exception ex)
            {
                logKeluarLabel.Text = $"Log: {lang.Get("Error_General")} {ex.Message}";
            }
            finally
            {
                idBarangKeluarTextBox.Clear();
                jumlahKeluarTextBox.Clear();
            }
        }

        private void terapkanFilterButton_Click(object sender, EventArgs e)
        {
            LoadAllItems();
        }
    }
}