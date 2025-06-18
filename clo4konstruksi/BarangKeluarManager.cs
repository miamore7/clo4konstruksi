using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace clo4konstruksi
{
    public class BarangKeluarConfig
    {
        public int JumlahMaksimalPerTransaksi { get; set; } = 100;
        public List<string> KategoriDilarang { get; set; } = new List<string>();
    }

    public class BarangKeluarManager
    {
        private BarangKeluarConfig _config;

        public BarangKeluarManager(string configPath = "Data/BarangKeluarConfig.json")
        {
            try
            {
                string json = File.ReadAllText(configPath);
                _config = JsonSerializer.Deserialize<BarangKeluarConfig>(json) ?? new BarangKeluarConfig();
            }
            catch { _config = new BarangKeluarConfig(); }
        }

        public void KeluarkanBarang(Item barang, int jumlah)
        {
            if (barang == null) throw new ArgumentNullException(nameof(barang));
            if (jumlah <= 0) throw new ArgumentException("Jumlah harus positif!");
            if (_config.KategoriDilarang.Contains(barang.Category)) throw new InvalidOperationException($"Kategori {barang.Category} dilarang!");
            if (jumlah > _config.JumlahMaksimalPerTransaksi) throw new InvalidOperationException($"Maksimal {_config.JumlahMaksimalPerTransaksi} per transaksi!");
            if (barang.Quantity < jumlah) throw new InvalidOperationException($"Stok hanya {barang.Quantity}!");
            barang.Quantity -= jumlah;
        }
    }
}