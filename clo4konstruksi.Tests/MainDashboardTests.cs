using Microsoft.VisualStudio.TestTools.UnitTesting;
using clo4konstruksi;
using System.Linq;

namespace clo4konstruksi.Tests
{
    [TestClass]
    public class MainDashboardTests
    {
        [TestMethod]
        public void GetFilteredItems_WhenFilterCategoryHP_ShouldReturnOnlyHP()
        {
            // Arrange
            var loginService = LoginService.Instance;
            var config = new FilterSortConfig { Kategori = "HP", UrutkanBerdasarkan = "Name", Naik = true };

            // Act
            var result = loginService.GetFilteredAndSortedItems(config);

            // Assert
            Assert.IsTrue(result.All(item => item.Category == "HP"));
        }

        [TestMethod]
        public void GetSortedItems_WhenSortByQuantityDesc_ShouldReturnCorrectOrder()
        {
            // Arrange
            var loginService = LoginService.Instance;
            var config = new FilterSortConfig { Kategori = "*", UrutkanBerdasarkan = "Quantity", Naik = false };

            // Act
            var result = loginService.GetFilteredAndSortedItems(config);

            // Assert
            Assert.AreEqual("HP", result.First().Category, "Item pertama seharusnya HP dengan stok terbanyak.");
            Assert.AreEqual(10, result.First().Quantity);
        }

        [TestMethod]
        public void SearchItems_WhenSearchForSamsung_ShouldReturnSamsung()
        {
            // Arrange
            var loginService = LoginService.Instance;

            // Act
            var allItems = loginService.GetItems();
            var searchResult = allItems.Where(i => i.Merk.ToLower().Contains("samsung")).ToList();

            // Assert
            Assert.AreEqual(1, searchResult.Count);
            Assert.AreEqual("Samsung", searchResult.First().Merk);
        }

        [TestMethod]
        public void GetWarehouseStatus_ShouldReturnCorrectString()
        {
            // Arrange
            var loginService = LoginService.Instance;

            // Act
            string status = loginService.InvManager.GetWarehouseStatus(loginService.LangManager);

            // Assert
            Assert.IsTrue(status.Contains("Kapasitas Gudang:"));
            Assert.IsTrue(status.Contains("HP:"));
            Assert.IsTrue(status.Contains("Laptop:"));
        }
    }
}