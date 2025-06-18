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

        public TransaksiBarangForm(Form loginForm)
        {
            InitializeComponent();
            _loginService = LoginService.Instance;
            _loginForm = loginForm;
        }

        private void TransaksiBarangForm_Load(object sender, EventArgs e)
        {
            // Muat data awal dan atur semua teks ke bahasa yang sesuai
            LoadAllItems();
            UpdateUITexts();
            itemsDataGridView_SelectionChanged(null, null); // Atur teks awal label info
        }

        #region Navigasi & Pencarian
        private void kembaliButton_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = new MainDashboard(_loginForm);
            dashboard.Show();
            this.Close();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadAllItems();
        }

        private void itemsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var lang = LoginService.Instance.LangManager;
            if (itemsDataGridView.CurrentRow != null && itemsDataGridView.CurrentRow.DataBoundItem is Item selectedItem)
            {
                selectionInfoLabel.Text = lang.Format("SelectedItemInfo", selectedItem.Merk, selectedItem.Name, selectedItem.Quantity);
            }
            else
            {
                selectionInfoLabel.Text = lang.Get("NoItemSelected");
            }
        }
        #endregion

        #region Logika Utama
        private void LoadAllItems()
        {
            List<Item> allItems = _loginService.GetItems();
            string searchTerm = searchTextBox.Text.ToLower().Trim();
            List<Item> finalResult;

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                finalResult = allItems;
            }
            else
            {
                finalResult = allItems.Where(item =>
                    item.Name.ToLower().Contains(searchTerm) ||
                    item.Merk.ToLower().Contains(searchTerm)
                ).ToList();
            }

            itemsDataGridView.DataSource = null;
            itemsDataGridView.DataSource = finalResult;
        }

        private void tambahBarangButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(namaBarangTextBox.Text) || string.IsNullOrWhiteSpace(merkTextBox.Text) || string.IsNullOrWhiteSpace(jumlahBarangTextBox.Text) || kategoriComboBox.SelectedItem == null) { MessageBox.Show("Semua kolom harus diisi."); return; }
            if (!int.TryParse(jumlahBarangTextBox.Text, out int jumlah) || jumlah <= 0) { MessageBox.Show("Jumlah harus angka positif."); return; }
            var newItem = new Item
            {
                Name = namaBarangTextBox.Text,
                Merk = merkTextBox.Text,
                Category = kategoriComboBox.SelectedItem.ToString(),
                Quantity = jumlah,
                TanggalMasuk = DateTime.Now
            };

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

        private void keluarkanButton_Click(object sender, EventArgs e)
        {
            var lang = LoginService.Instance.LangManager;
            if (itemsDataGridView.CurrentRow == null) { MessageBox.Show("Silakan pilih barang di tabel terlebih dahulu."); return; }
            try
            {
                Item selectedItem = itemsDataGridView.CurrentRow.DataBoundItem as Item;
                if (selectedItem == null) return;

                if (!int.TryParse(jumlahKeluarTextBox.Text, out int jumlah) || jumlah <= 0)
                {
                    throw new ArgumentException(lang.Get("Error_JumlahInvalid"));
                }

                int stokLama = selectedItem.Quantity;
                // Kurangi stok barang
                LoginService.Instance.BarangKeluarMgr.KeluarkanBarang(selectedItem, jumlah);

                // -- BAGIAN PERBAIKAN --
                // Periksa apakah stok barang menjadi 0, jika ya, hapus dari daftar
                LoginService.Instance.RemoveItemIfOutOfStock(selectedItem);
                // -- AKHIR PERBAIKAN --

                // Simpan perubahan ke file (bisa jadi pengurangan stok atau penghapusan item)
                LoginService.Instance.SaveItems();

                // Muat ulang semua tampilan
                LoadAllItems();
                logKeluarLabel.Text = $"{lang.Get("LogPrefix")} {lang.Format("SuccessMessage", jumlah, selectedItem.Name, stokLama, selectedItem.Quantity)}";
            }
            catch (Exception ex)
            {
                logKeluarLabel.Text = $"{lang.Get("LogPrefix")} {lang.Get("Error_General")} {ex.Message}";
            }
            finally { jumlahKeluarTextBox.Clear(); }
        }
        #endregion

        #region UI Helper
        private void UpdateUITexts()
        {
            var lang = LoginService.Instance.LangManager;

            kembaliButton.Text = lang.Get("BackButton");

            barangMasukTabPage.Text = lang.Get("TabInbound");
            barangKeluarTabPage.Text = lang.Get("TabOutbound");

            // Tab Barang Masuk
            if (inboundTitleLabel != null) inboundTitleLabel.Text = lang.Get("InboundGoodsTitle");
            if (TipeBarangLabel != null) TipeBarangLabel.Text = lang.Get("SortByName");
            if (merkLabel != null) merkLabel.Text = lang.Get("SortByBrand");
            if (jumlahLabel != null) jumlahLabel.Text = lang.Get("QuantityLabel");
            if (jenisLabel != null) jenisLabel.Text = lang.Get("CategoryLabel");
            tambahBarangButton.Text = lang.Get("AddItemButton");
            searchTextBox.WaterMark = lang.Get("SearchPrompt");

            // Tab Barang Keluar
            if (outboundTitleLabel != null) outboundTitleLabel.Text = lang.Get("OutboundTitle");
            if (jumlahKeluarLabel != null) jumlahKeluarLabel.Text = lang.Get("InputJumlah");
            keluarkanButton.Text = lang.Get("IssueItemButton");
            if (logKeluarLabel != null) logKeluarLabel.Text = lang.Get("LogPrefix");
            if (selectionInfoLabel != null) selectionInfoLabel.Text = lang.Get("NoItemSelected");
        }
        #endregion
    }
}