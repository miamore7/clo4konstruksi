using System;
using System.Windows.Forms;

namespace clo4konstruksi
{
    public partial class AdminDashboardForm : Form
    {
        private LoginService _loginService;

        // Kita tidak lagi butuh referensi ke Login Form di sini
        // private Form _loginForm; 

        public AdminDashboardForm() // Constructor kembali sederhana
        {
            InitializeComponent();
            _loginService = LoginService.Instance;
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            // Saat form dibuka, hanya muat data barang.
            // GroupBox manajemen admin sudah kita atur Visible = False di Desainer.
            LoadAllItems();
        }

        private void lihatAkunButton_Click(object sender, EventArgs e)
        {
            if (LoginService.Instance.LoggedInUser.Role == "SuperAdmin")
            {
                // Tampilkan GroupBox dan muat datanya
                manajemenAdminGroupBox.Visible = true;
                LoadUserData();
            }
            else
            {
                MessageBox.Show("Anda Bukan Super Admin.", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Metode untuk Logout (ini perlu diperbaiki karena _loginForm sudah dihapus)
        // Kita akan sederhanakan untuk saat ini
        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda yakin ingin keluar?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Untuk sementara, cara termudah adalah menutup aplikasi
                Application.Exit();
                // Nanti kita bisa perbaiki agar kembali ke form login
            }
        }

        // --- Metode untuk memuat data ---
        private void LoadAllItems()
        {
            itemsDataGridView.DataSource = _loginService.GetItems();
        }

        private void LoadUserData()
        {
            usersDataGridView.DataSource = _loginService.GetAllUsers();
        }

        // --- Metode untuk tombol di dalam GroupBox ---
        private void setActiveButton_Click(object sender, EventArgs e)
        {
            SetSelectedUserStatus(true);
        }

        private void setInactiveButton_Click(object sender, EventArgs e)
        {
            SetSelectedUserStatus(false);
        }

        private void SetSelectedUserStatus(bool newStatus)
        {
            if (usersDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih user terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = usersDataGridView.CurrentRow.Cells["Username"].Value.ToString();
            _loginService.SetUserStatus(username, newStatus);
            LoadUserData();
            MessageBox.Show($"Status user '{username}' berhasil diubah.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}