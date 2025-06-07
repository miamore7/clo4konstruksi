using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace clo4konstruksi
{
    public class LoginService
    {
        // 1. Tambahkan static property untuk menampung satu-satunya instance
        private static LoginService _instance;

        // Properti lain tetap sama
        private List<User> users;
        private readonly string filePath = "users.json";
        public User LoggedInUser { get; private set; }
        public LoginState CurrentLoginState { get; private set; } = LoginState.LoggedOut;

        // 2. Buat constructor menjadi PRIVATE
        private LoginService()
        {
            LoadUsers();
        }

        // 3. Buat properti publik untuk mengakses satu-satunya instance
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

        private List<Item> items = new List<Item>
        {
            new Item { Id = "B001", Name = "Samsung Galaxy S21", Category = "HP", Quantity = 10 },
            new Item { Id = "B002", Name = "iPhone 13", Category = "HP", Quantity = 7 },
            new Item { Id = "B003", Name = "Dell XPS 13", Category = "Laptop", Quantity = 5 },
            new Item { Id = "B004", Name = "MacBook Pro", Category = "Laptop", Quantity = 3 }
        };
        public List<Item> GetItems(string category = null, bool sortByName = false)
        {
            IEnumerable<Item> query = items;

            if (!string.IsNullOrEmpty(category))
            {
                query = query.Where(i => i.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
            }

            if (sortByName)
            {
                query = query.OrderBy(i => i.Name);
            }

            return query.ToList();
        }

        // --- SEMUA METODE LAIN (LoadUsers, SaveUsers, Login, dll) TETAP SAMA ---
        // --- Cukup salin semua metode Anda yang lain di bawah sini ---

        private void LoadUsers()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
            }
            else
            {
                users = new List<User>();
            }
        }

        private void SaveUsers()
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public bool Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username)) throw new ArgumentException("Username tidak boleh kosong.");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Password tidak boleh kosong.");

            // Langsung bandingkan password dari input dengan yang ada di data
            LoggedInUser = users.FirstOrDefault(u => u.Username == username && u.Password == password && u.IsActive);

            if (LoggedInUser != null)
            {
                CurrentLoginState = LoginState.LoggedIn;
                return true;
            }

            return false;
        }

        public List<User> GetAllUsers()
        {
            return users.Where(u => u.Role != "SuperAdmin").ToList();
        }

        public void SetUserStatus(string username, bool isActive)
        {
            var userToUpdate = users.FirstOrDefault(u => u.Username == username);
            if (userToUpdate != null)
            {
                userToUpdate.IsActive = isActive;
                SaveUsers();
            }
        }

        public void Logout()
        {
            LoggedInUser = null;
            CurrentLoginState = LoginState.LoggedOut;
        }
    }
}