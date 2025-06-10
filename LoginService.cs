using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace clo4konstruksi
{
    public class LoginService
    {
        private static LoginService _instance;
        private List<User> users;
        private List<Item> items;
        private readonly string _userFilePath = "Data/users.json";
        private readonly string _itemFilePath = "Data/DataBarang.json";
        private readonly string _viewConfigPath = "Data/TampilanConfig.json";
        private readonly Dictionary<string, int> _capacities = new Dictionary<string, int> { { "HP", 500 }, { "Laptop", 1000 } };

        public User LoggedInUser { get; private set; }
        public LoginState CurrentLoginState { get; private set; } = LoginState.LoggedOut;
        public InventoryManager InvManager { get; private set; }
        public FilterSortConfig ViewConfig { get; set; }
        public LanguageManager LangManager { get; private set; }
        public BarangKeluarManager BarangKeluarMgr { get; private set; }

        private LoginService()
        {
            LoadUsers();
            LoadItems();
            LoadViewConfig();
            InvManager = new InventoryManager(this.items, this._capacities);
            LangManager = new LanguageManager();
            LangManager.LoadLanguage("ID");
            BarangKeluarMgr = new BarangKeluarManager();
        }

        public static LoginService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LoginService();
                }
                return _instance;
            }
        }

        private void LoadUsers()
        {
            if (File.Exists(_userFilePath))
            {
                string json = File.ReadAllText(_userFilePath);
                users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
            }
            else { users = new List<User>(); }
        }

        private void SaveUsers()
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_userFilePath, json);
        }

        private void LoadItems()
        {
            if (File.Exists(_itemFilePath))
            {
                string json = File.ReadAllText(_itemFilePath);
                items = JsonSerializer.Deserialize<List<Item>>(json) ?? new List<Item>();
            }
            else { items = new List<Item>(); }
        }

        public void SaveItems()
        {
            string json = JsonSerializer.Serialize(items, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_itemFilePath, json);
        }

        public bool Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)) return false;
            LoggedInUser = users.FirstOrDefault(u => u.Username == username && u.Password == password && u.IsActive);
            if (LoggedInUser != null)
            {
                CurrentLoginState = LoginState.LoggedIn;
                return true;
            }
            return false;
        }

        public void Logout()
        {
            LoggedInUser = null;
            CurrentLoginState = LoginState.LoggedOut;
        }

        public List<Item> GetItems() => items;
        public List<User> GetAllUsers() => users.Where(u => u.Role != "SuperAdmin").ToList();
        public void SetUserStatus(string username, bool isActive)
        {
            var userToUpdate = users.FirstOrDefault(u => u.Username == username);
            if (userToUpdate != null)
            {
                userToUpdate.IsActive = isActive;
                SaveUsers();
            }
        }

        public void CreateAdmin(string username, string password)
        {
            if (users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException("Username sudah digunakan.");
            }

            var newUser = new User
            {
                Username = username,
                Password = password, // Ingat, kita masih pakai plain text
                Role = "admin",
                IsActive = true
            };
            users.Add(newUser);
            SaveUsers();
        }

        public void DeleteUser(string username)
        {
            var userToRemove = users.FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
            if (userToRemove != null)
            {
                users.Remove(userToRemove);
                SaveUsers();
            }
        }

        public List<Item> GetFilteredAndSortedItems(FilterSortConfig config)
        {
            IEnumerable<Item> result = items;

            // --- BAGIAN YANG DIPERBAIKI ---
            // 1. Ambil dulu teks "(Semua)" dari LanguageManager sesuai bahasa aktif
            string allFilterText = this.LangManager.Get("AllFilter");

            // 2. Proses Filter dengan membandingkan dengan teks yang sudah diterjemahkan
            if (config.Kategori != null && config.Kategori != allFilterText)
            {
                result = result.Where(item => item.Category == config.Kategori);
            }
            // --- AKHIR BAGIAN YANG DIPERBAIKI ---

            // 3. Proses Sorting (bagian ini sudah benar, tidak perlu diubah)
            switch (config.UrutkanBerdasarkan)
            {
                case "Nama":
                    result = config.Naik ? result.OrderBy(item => item.Name) : result.OrderByDescending(item => item.Name);
                    break;
                case "Merk":
                    result = config.Naik ? result.OrderBy(item => item.Merk) : result.OrderByDescending(item => item.Merk);
                    break;
                case "Quantity":
                    result = config.Naik ? result.OrderBy(item => item.Quantity) : result.OrderByDescending(item => item.Quantity);
                    break;
                    // TanggalMasuk sengaja saya hapus karena sepertinya Anda sudah menghapusnya dari ComboBox
            }

            return result.ToList();
        }

        private void LoadViewConfig()
        {
            // Pengecekan untuk memastikan file ada sebelum dibaca
            if (File.Exists(_viewConfigPath))
            {
                string json = File.ReadAllText(_viewConfigPath);
                ViewConfig = JsonSerializer.Deserialize<FilterSortConfig>(json) ?? new FilterSortConfig();
            }
            else
            {
                // Jika file tidak ada, buat konfigurasi default
                ViewConfig = new FilterSortConfig { Kategori = "(Semua)", UrutkanBerdasarkan = "Nama", Naik = true };
            }
        }

        public void SaveViewConfig()
        {
            string json = JsonSerializer.Serialize(ViewConfig, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_viewConfigPath, json);
        }
    }
}