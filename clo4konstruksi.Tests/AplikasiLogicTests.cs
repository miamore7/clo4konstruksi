using Microsoft.VisualStudio.TestTools.UnitTesting;
using clo4konstruksi;
using System;
using System.Collections.Generic;
using System.Linq;

namespace clo4konstruksi.Tests
{
    [TestClass]
    public class AplikasiLengkapTests
    {
        // Catatan: Karena LoginService adalah Singleton, state-nya akan terbawa antar test.
        // Untuk test yang bersih, idealnya ada metode [TestInitialize] untuk mereset state,
        // tapi untuk tugas ini, kita buat test yang independen.

        #region Test Fitur Login & Manajemen Akun (Ellen)
        [TestMethod]
        public void Login_WithInvalidPassword_ShouldFail()
        {
            // Arrange
            var loginService = LoginService.Instance;

            // Act
            bool result = loginService.Login("admin", "password_salah");

            // Assert
            Assert.IsFalse(result, "Login seharusnya gagal dengan password yang salah.");
        }

        [TestMethod]
        public void SetUserStatus_WhenSetToInactive_UserShouldNotBeAbleToLogin()
        {
            // Arrange
            var loginService = LoginService.Instance;
            // Pastikan user 'user' ada dan aktif untuk diuji
            loginService.SetUserStatus("user", true);

            // Act
            loginService.SetUserStatus("user", false); // Non-aktifkan user
            bool loginResult = loginService.Login("user", "user"); // Coba login

            // Assert
            Assert.IsFalse(loginResult, "Pengguna yang tidak aktif seharusnya tidak bisa login.");

            // Cleanup: Aktifkan kembali user untuk test lain
            loginService.SetUserStatus("user", true);
        }
        #endregion


        #region Test Fitur Inventaris & Kapasitas (Michael)
        [TestMethod]
        public void AddItem_WithNewItem_ShouldIncreaseListCountAndSetCorrectId()
        {
            // Arrange
            var items = new List<Item>();
            var capacities = new Dictionary<string, int> { { "Laptop", 5 } };
            var invManager = new InventoryManager(items, capacities);
            var newItem = new Item { Name = "Laptop Gaming", Merk = "BrandX", Category = "Laptop", Quantity = 1 };

            // Act
            invManager.AddItem(newItem);

            // Assert
            Assert.AreEqual(1, items.Count, "Jumlah item di list seharusnya bertambah 1.");
            Assert.AreEqual("LP001", items[0].Id, "ID untuk Laptop pertama seharusnya LP001.");
        }

        [TestMethod]
        public void CanAddItem_WhenCapacityIsFull_ShouldReturnFalse()
        {
            // Arrange
            var items = new List<Item> { new Item { Name = "Laptop Lama", Category = "Laptop", Quantity = 10 } };
            var capacities = new Dictionary<string, int> { { "Laptop", 10 } }; // Kapasitas penuh
            var invManager = new InventoryManager(items, capacities);
            var newItem = new Item { Name = "Laptop Baru", Category = "Laptop", Quantity = 1 };

            // Act
            bool result = invManager.CanAddItem(newItem, out string errorMessage);

            // Assert
            Assert.IsFalse(result, "Seharusnya tidak bisa menambah barang jika kapasitas penuh.");
            Assert.IsFalse(string.IsNullOrEmpty(errorMessage), "Seharusnya ada pesan error kapasitas.");
        }
        #endregion


        #region Test Fitur Barang Keluar (Ageng)
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))] // Mengharapkan error jenis ini
        public void KeluarkanBarang_WhenAmountExceedsMaxTransaction_ShouldThrowException()
        {
            // Arrange
            var barangKeluarMgr = new BarangKeluarManager("Data/BarangKeluarConfig.json");
            var item = new Item { Name = "Test Item", Category = "HP", Quantity = 20 };
            int amountToIssue = 11; // Melebihi batas di config (10)

            // Act
            barangKeluarMgr.KeluarkanBarang(item, amountToIssue);

            // Assert
            // Lolos jika exception terjadi
        }
        #endregion


        #region Test Fitur Filter & Sort (Farrel)
        [TestMethod]
        public void GetFilteredAndSortedItems_WhenSortByQuantityDescending_ShouldReturnCorrectOrder()
        {
            // Arrange
            var loginService = LoginService.Instance;
            var config = new FilterSortConfig
            {
                Kategori = "*", // Tidak filter kategori
                UrutkanBerdasarkan = "Quantity",
                Naik = false // Descending (terbesar ke terkecil)
            };

            // Act
            var result = loginService.GetFilteredAndSortedItems(config);

            // Assert
            Assert.IsNotNull(result, "Hasil tidak boleh null.");
            Assert.IsTrue(result.Count > 0, "Hasil tidak boleh kosong.");
            // Asumsikan data awal memiliki item dengan Quantity 10, 7, 5, 3
            Assert.AreEqual(10, result.First().Quantity, "Item pertama seharusnya memiliki kuantitas terbanyak.");
        }
        #endregion
    }
}