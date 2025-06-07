using System;
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
            // Muat data awal
            LoadAllItems();
            UpdateCapacityStatus();

            // Logika BARU: Tombol Manajemen Akun hanya terlihat untuk Super Admin
            if (LoginService.Instance.LoggedInUser.Role == "SuperAdmin")
            {
                manajemenAkunButton.Visible = true;
            }
            else
            {
                manajemenAkunButton.Visible = false;
            }
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
            itemsDataGridView.DataSource = null;
            itemsDataGridView.DataSource = _loginService.GetItems();
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
    }
}