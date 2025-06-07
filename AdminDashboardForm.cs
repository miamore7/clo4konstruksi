using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace clo4konstruksi
{
    public partial class AdminDashboardForm : MetroFramework.Forms.MetroForm
    {
        private LoginService _loginService;
        private Form _loginForm;

        public AdminDashboardForm(Form loginForm)
        {
            InitializeComponent();
            _loginService = LoginService.Instance;
            _loginForm = loginForm;
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda yakin ingin keluar?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginService.Instance.Logout();
                _loginForm.Show();
                this.Close();
            }
        }

        private void loadDataButton_Click(object sender, EventArgs e) { LoadAllItems(); }
        private void LoadAllItems()
        {
            itemsDataGridView.DataSource = null;
            itemsDataGridView.DataSource = _loginService.GetItems();
        }

        private void loadAdminButton_Click(object sender, EventArgs e) { LoadUserData(); }
        private void LoadUserData()
        {
            usersDataGridView.DataSource = null;
            usersDataGridView.DataSource = _loginService.GetAllUsers();
        }

        private void setActiveButton_Click(object sender, EventArgs e) { SetSelectedUserStatus(true); }
        private void setInactiveButton_Click(object sender, EventArgs e) { SetSelectedUserStatus(false); }
        private void SetSelectedUserStatus(bool newStatus)
        {
            if (usersDataGridView.CurrentRow == null) { MessageBox.Show("Silakan pilih user."); return; }
            string username = usersDataGridView.CurrentRow.Cells["Username"].Value.ToString();
            _loginService.SetUserStatus(username, newStatus);
            LoadUserData();
            MessageBox.Show($"Status user '{username}' berhasil diubah.");
        }

        private void UpdateCapacityStatus() { statusGudangLabel.Text = LoginService.Instance.InvManager.GetWarehouseStatus(); }
        private void tambahBarangButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(namaBarangTextBox.Text) || string.IsNullOrWhiteSpace(merkTextBox.Text) || string.IsNullOrWhiteSpace(jumlahBarangTextBox.Text) || kategoriComboBox.SelectedItem == null) { MessageBox.Show("Semua kolom harus diisi."); return; }
            if (!int.TryParse(jumlahBarangTextBox.Text, out int jumlah) || jumlah <= 0) { MessageBox.Show("Jumlah harus angka positif."); return; }
            var newItem = new Item { Name = namaBarangTextBox.Text, Merk = merkTextBox.Text, Category = kategoriComboBox.SelectedItem.ToString(), Quantity = jumlah };
            if (LoginService.Instance.InvManager.CanAddItem(newItem, out string errorMessage))
            {
                LoginService.Instance.InvManager.AddItem(newItem);
                LoginService.Instance.SaveItems();
                MessageBox.Show("Barang berhasil ditambahkan/diupdate.");
                namaBarangTextBox.Clear(); merkTextBox.Clear(); jumlahBarangTextBox.Clear();
                LoadAllItems(); UpdateCapacityStatus();
            }
            else { MessageBox.Show(errorMessage, "Kapasitas Penuh"); }
        }

        private void keluarkanButton_Click(object sender, EventArgs e)
        {
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
                LoadAllItems(); UpdateCapacityStatus();
                logKeluarLabel.Text = $"Log: {lang.Format("SuccessMessage", jumlah, barang.Name, stokLama, barang.Quantity)}";
            }
            catch (Exception ex) { logKeluarLabel.Text = $"Log: {lang.Get("Error_General")} {ex.Message}"; }
            finally { idBarangKeluarTextBox.Clear(); jumlahKeluarTextBox.Clear(); }
        }
    }
}