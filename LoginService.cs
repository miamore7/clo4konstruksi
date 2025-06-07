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
        private readonly Dictionary<string, int> _capacities = new Dictionary<string, int> { { "HP", 500 }, { "Laptop", 1000 } };

        public User LoggedInUser { get; private set; }
        public LoginState CurrentLoginState { get; private set; } = LoginState.LoggedOut;
        public InventoryManager InvManager { get; private set; }
        public LanguageManager LangManager { get; private set; }
        public BarangKeluarManager BarangKeluarMgr { get; private set; }

        private LoginService()
        {
            LoadUsers();
            LoadItems();
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
    }
}