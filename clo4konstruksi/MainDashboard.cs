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

        public MainDashboard(Form loginForm)
        {
            InitializeComponent();
            _loginService = LoginService.Instance;
            _loginForm = loginForm;
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            // --- URUTAN EKSEKUSI YANG BENAR ---

            // 1. Isi ComboBox untuk sorting
            PopulateSortByComboBox();

            // 2. Terapkan bahasa yang sedang aktif ke seluruh UI
            UpdateUITexts();

            // 3. Setelah UI diterjemahkan, atur pilihan filter/sort dari konfigurasi yang tersimpan
            string savedCategoryKey = _loginService.ViewConfig.Kategori;
            if (savedCategoryKey == "*")
            {
                filterKategoriComboBox.SelectedItem = _loginService.LangManager.Get("AllFilter");
            }
            else
            {
                filterKategoriComboBox.SelectedItem = savedCategoryKey;
            }

            sortByComboBox.SelectedValue = _loginService.ViewConfig.UrutkanBerdasarkan ?? "Name";
            sortOrderToggle.Checked = _loginService.ViewConfig.Naik;

            // 4. Muat data ke tabel berdasarkan pengaturan UI yang sudah benar
            LoadAllItems();

            // 5. Atur hak akses tombol Super Admin
            manajemenAkunButton.Visible = (LoginService.Instance.LoggedInUser.Role == "SuperAdmin");
        }

        #region Navigasi & Bahasa
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
            ManajemenAkunForm form = new ManajemenAkunForm(_loginForm);
            form.Show();
            this.Close();
        }

        private void transaksiButton_Click(object sender, EventArgs e)
        {
            TransaksiBarangForm form = new TransaksiBarangForm(_loginForm);
            form.Show();
            this.Close();
        }

        private void languageToggle_CheckedChanged(object sender, EventArgs e)
        {
            var langManager = LoginService.Instance.LangManager;
            if (languageToggle.Checked) { langManager.LoadLanguage("EN"); }
            else { langManager.LoadLanguage("ID"); }
            UpdateUITexts();
        }
        #endregion

        #region Logika Filter, Sort, & Search
        private void LoadAllItems()
        {
            string kategoriFilterValue;
            string allFilterText = _loginService.LangManager.Get("AllFilter");
            if (filterKategoriComboBox.Text == allFilterText)
            {
                kategoriFilterValue = "*";
            }
            else
            {
                kategoriFilterValue = filterKategoriComboBox.Text;
            }

            var config = new FilterSortConfig
            {
                Kategori = kategoriFilterValue,
                UrutkanBerdasarkan = sortByComboBox.SelectedValue?.ToString() ?? "Name",
                Naik = sortOrderToggle.Checked
            };
            List<Item> filteredAndSortedItems = _loginService.GetFilteredAndSortedItems(config);

            string searchTerm = searchTextBox.Text.ToLower().Trim();
            List<Item> finalResult;
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                finalResult = filteredAndSortedItems;
            }
            else
            {
                finalResult = filteredAndSortedItems.Where(item =>
                    item.Name.ToLower().Contains(searchTerm) ||
                    item.Merk.ToLower().Contains(searchTerm)
                ).ToList();
            }
            itemsDataGridView.DataSource = null;
            itemsDataGridView.DataSource = finalResult;
        }

        private void terapkanFilterButton_Click(object sender, EventArgs e)
        {
            string selectedCategory = filterKategoriComboBox.Text;
            string allFilterText = _loginService.LangManager.Get("AllFilter");
            if (selectedCategory == allFilterText)
            {
                _loginService.ViewConfig.Kategori = "*";
            }
            else
            {
                _loginService.ViewConfig.Kategori = selectedCategory;
            }

            _loginService.ViewConfig.UrutkanBerdasarkan = sortByComboBox.SelectedValue.ToString();
            _loginService.ViewConfig.Naik = sortOrderToggle.Checked;
            _loginService.SaveViewConfig();
            LoadAllItems();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadAllItems();
        }
        #endregion

        #region Metode Helper untuk UI
        private void UpdateCapacityStatus()
        {
            statusGudangLabel.Text = LoginService.Instance.InvManager.GetWarehouseStatus(LoginService.Instance.LangManager);
        }

        private void PopulateSortByComboBox()
        {
            var lang = _loginService.LangManager;
            var currentSelection = sortByComboBox.SelectedValue;

            var sortOptions = new List<SortOption>
    {
        new SortOption { DisplayText = lang.Get("SortByName"), Value = "Name" },
        new SortOption { DisplayText = lang.Get("SortByBrand"), Value = "Merk" },
        new SortOption { DisplayText = lang.Get("SortByQuantity"), Value = "Quantity" },
        // TAMBAHKAN BARIS INI
        new SortOption { DisplayText = lang.Get("SortByDate"), Value = "TanggalMasuk" }
    };

            sortByComboBox.DataSource = sortOptions;
            sortByComboBox.DisplayMember = "DisplayText";
            sortByComboBox.ValueMember = "Value";

            if (currentSelection != null)
            {
                sortByComboBox.SelectedValue = currentSelection;
            }
        }

        private void UpdateUITexts()
        {
            var lang = LoginService.Instance.LangManager;

            PopulateSortByComboBox();

            logoutButton.Text = lang.Get("LogoutButton");
            manajemenAkunButton.Text = lang.Get("TabAccounts");
            transaksiButton.Text = lang.Get("TransactionButton");
            languageLabel.Text = lang.Get("LanguageLabel");
            filterLabel.Text = lang.Get("FilterCategoryLabel");
            sortLabel.Text = lang.Get("SortByLabel");
            sortOrderToggle.Text = lang.Get("SortOrderLabel");
            terapkanFilterButton.Text = lang.Get("ApplyFilterButton");
            searchTextBox.WaterMark = lang.Get("SearchPrompt");

            if (filterKategoriComboBox.Items.Count > 0)
            {
                filterKategoriComboBox.Items[0] = lang.Get("AllFilter");
            }

            UpdateCapacityStatus();
        }
        #endregion
    }
}