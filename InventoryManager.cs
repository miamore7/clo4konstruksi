using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clo4konstruksi
{
    public class InventoryManager
    {
        private List<Item> inventory;
        private readonly Dictionary<string, int> categoryCapacities;

        public InventoryManager(List<Item> initialInventory, Dictionary<string, int> capacities)
        {
            inventory = initialInventory;
            categoryCapacities = capacities;
        }

        public bool CanAddItem(Item item, out string errorMessage)
        {
            errorMessage = "";
            if (!categoryCapacities.ContainsKey(item.Category))
            {
                errorMessage = $"Kategori '{item.Category}' tidak memiliki data kapasitas.";
                return false;
            }
            int currentQty = GetCurrentQuantityFor(item.Category);
            int capacity = categoryCapacities[item.Category];
            if (currentQty + item.Quantity > capacity)
            {
                errorMessage = $"Kapasitas untuk {item.Category} tidak mencukupi. Sisa kapasitas: {capacity - currentQty}.";
                return false;
            }
            return true;
        }

        public void AddItem(Item item)
        {
            var existingItem = inventory.FirstOrDefault(i => i.Name.Equals(item.Name, System.StringComparison.OrdinalIgnoreCase));
            if (existingItem != null)
            {
                existingItem.Quantity += item.Quantity;
            }
            else
            {
                // --- BAGIAN YANG DIPERBAIKI ---
                string prefix;
                switch (item.Category)
                {
                    case "HP":
                        prefix = "HP";
                        break;
                    case "Laptop":
                        prefix = "LP";
                        break;
                    default:
                        prefix = "BRG";
                        break;
                }
                // --- AKHIR BAGIAN YANG DIPERBAIKI ---

                int nextNumber = inventory.Count(i => i.Category == item.Category) + 1;
                item.Id = prefix + nextNumber.ToString("D3");
                inventory.Add(item);
            }
        }

        public string GetWarehouseStatus()
        {
            StringBuilder status = new StringBuilder("Kapasitas Gudang: ");
            foreach (var category in categoryCapacities.Keys)
            {
                int currentQty = GetCurrentQuantityFor(category);
                int capacity = categoryCapacities[category];
                status.Append($"| {category}: {currentQty}/{capacity} ");
                if (currentQty >= capacity) { status.Append("(Full) "); }
            }
            return status.ToString();
        }

        private int GetCurrentQuantityFor(string category)
        {
            return inventory.Where(i => i.Category == category).Sum(i => i.Quantity);
        }
    }
}