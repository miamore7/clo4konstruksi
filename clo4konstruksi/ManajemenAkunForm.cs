using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace clo4konstruksi
{
    public partial class ManajemenAkunForm : MetroFramework.Forms.MetroForm
    {
        private LoginService _loginService;
        private Form _loginForm; // Untuk kembali ke dashboard

        private void UpdateUITexts()
        {
            var lang = LoginService.Instance.LangManager;

            this.Text = lang.Get("TabAccounts");

            // Atur judul GroupBox
            groupBox1.Text = lang.Get("CreateAccountTitle");

            // Atur WaterMark untuk TextBox
            newUsernameTextBox.WaterMark = lang.Get("NewUsernamePrompt");
            newPasswordTextBox.WaterMark = lang.Get("NewPasswordPrompt");

            // Atur teks semua tombol
            loadAdminButton.Text = lang.Get("LoadAdminButton");
            setActiveButton.Text = lang.Get("ActivateButton");
            setInactiveButton.Text = lang.Get("DeactivateButton");
            createAdminButton.Text = lang.Get("CreateAccountButton");
            deleteAdminButton.Text = lang.Get("DeleteAccountButton");

            // Menggunakan kunci "BackButton" yang baru
            kembaliButton.Text = lang.Get("BackButton");
        }

        public ManajemenAkunForm(Form loginForm)
        {
            InitializeComponent();
            _loginService = LoginService.Instance;
            _loginForm = loginForm;
        }

        private void ManajemenAkunForm_Load(object sender, EventArgs e)
        {
            LoadUserData();
            UpdateUITexts();
        }

        private void LoadUserData()
        {
            usersDataGridView.DataSource = null;
            usersDataGridView.DataSource = _loginService.GetAllUsers();
        }

        private void loadAdminButton_Click(object sender, EventArgs e) => LoadUserData();
        private void setActiveButton_Click(object sender, EventArgs e) => SetSelectedUserStatus(true);
        private void setInactiveButton_Click(object sender, EventArgs e) => SetSelectedUserStatus(false);

        private void SetSelectedUserStatus(bool newStatus)
        {
            if (usersDataGridView.CurrentRow == null) { MessageBox.Show("Pilih user terlebih dahulu."); return; }
            string username = usersDataGridView.CurrentRow.Cells["Username"].Value.ToString();
            _loginService.SetUserStatus(username, newStatus);
            LoadUserData();
            MessageBox.Show($"Status user '{username}' berhasil diubah.");
        }

        private void createAdminButton_Click(object sender, EventArgs e)
        {
            string newUser = newUsernameTextBox.Text;
            string newPass = newPasswordTextBox.Text;

            if (string.IsNullOrWhiteSpace(newUser) || string.IsNullOrWhiteSpace(newPass))
            {
                MessageBox.Show("Username dan Password baru tidak boleh kosong.");
                return;
            }

            try
            {
                _loginService.CreateAdmin(newUser, newPass);
                MessageBox.Show($"Admin '{newUser}' berhasil dibuat.");
                LoadUserData();
                newUsernameTextBox.Clear();
                newPasswordTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuat admin: " + ex.Message);
            }
        }

        private void deleteAdminButton_Click(object sender, EventArgs e)
        {
            if (usersDataGridView.CurrentRow == null) { MessageBox.Show("Pilih user yang akan dihapus."); return; }

            string username = usersDataGridView.CurrentRow.Cells["Username"].Value.ToString();
            var confirmResult = MessageBox.Show($"Anda yakin ingin menghapus admin '{username}' secara permanen?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                _loginService.DeleteUser(username);
                MessageBox.Show($"Admin '{username}' berhasil dihapus.");
                LoadUserData();
            }
        }

        private void kembaliButton_Click(object sender, EventArgs e)
        {
            // Buka lagi dashboard utama dan tutup form ini
            MainDashboard dashboard = new MainDashboard(_loginForm);
            dashboard.Show();
            this.Close();
        }
    }
}