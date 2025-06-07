using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clo4konstruksi
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        private LoginService _loginService;

        public LoginForm()
        {
            InitializeComponent();
            _loginService = LoginService.Instance;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            try
            {
                if (_loginService.Login(username, password))
                {
                    MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Sembunyikan form login saat ini
                    this.Hide();

                    // Buat dan tampilkan form dashboard admin
                    AdminDashboardForm adminForm = new AdminDashboardForm();
                    adminForm.Show();
                }
                else
                {
                    MessageBox.Show("Username atau password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
