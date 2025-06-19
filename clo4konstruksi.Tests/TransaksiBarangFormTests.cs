using Microsoft.VisualStudio.TestTools.UnitTesting;
using clo4konstruksi;
using System;
using System.Collections.Generic;

namespace clo4konstruksi.Tests
{
    [TestClass]
    public class TransaksiBarangFormTests
    {
        [TestMethod]
        public void AddItem_WhenAddingNewItem_ShouldUpdateInventory()
        {
            // Arrange
            var loginService = LoginService.Instance;
            var initialCount = loginService.GetItems().Count;
            var newItem = new Item { Name = "Laptop Baru", Merk = "Merk Baru", Category = "Laptop", Quantity = 5 };

            // Act
            loginService.InvManager.AddItem(newItem);

            // Assert
            Assert.AreEqual(initialCount + 1, loginService.GetItems().Count, "Jumlah item seharusnya bertambah 1.");
        }

        [TestMethod]
        public void AddItem_WhenCapacityExceeded_ShouldReturnFalse()
        {
            // Arrange
            var loginService = LoginService.Instance;
            // Buat item yang akan melebihi kapasitas Laptop (1000)
            var overloadItem = new Item { Name = "Laptop Overload", Merk = "Brand", Category = "Laptop", Quantity = 999 };

            // Act
            bool canAdd = loginService.InvManager.CanAddItem(overloadItem, out string errorMessage);

            // Assert
            Assert.IsFalse(canAdd);
            Assert.IsFalse(string.IsNullOrEmpty(errorMessage));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void KeluarkanBarang_WithInsufficientStock_ShouldThrowException()
        {
            // Arrange
            var barangKeluarMgr = new BarangKeluarManager();
            var item = new Item { Name = "Test Item", Category = "HP", Quantity = 2 };

            // Act
            barangKeluarMgr.KeluarkanBarang(item, 5); // Mencoba keluar 5, stok 2

            // Assert - Lolos jika exception terjadi
        }

        [TestMethod]
        public void RemoveItemIfOutOfStock_WhenStockIsZero_ShouldRemoveItem()
        {
            // Arrange
            var loginService = LoginService.Instance;
            var itemToRemove = new Item { Name = "Item Dihapus", Category = "HP", Quantity = 0 };
            loginService.GetItems().Add(itemToRemove);
            var initialCount = loginService.GetItems().Count;

            // Act
            loginService.RemoveItemIfOutOfStock(itemToRemove);

            // Assert
            Assert.AreEqual(initialCount - 1, loginService.GetItems().Count, "Item dengan stok 0 seharusnya dihapus.");
        }
    }
}