using programserderhanaC_;

namespace ProductTransactionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product("Laptop", 3000.00),
                new Product("Smartphone", 800.00),
                new Product("Headphones", 200.00),
                new Product("Tablet", 500.00),
                new Product("Camera", 700.00)
            };

            DisplayProductList(products);

            // Meminta pengguna untuk memilih produk
            Console.Write("Pilih nomor produk yang ingin Anda beli: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            // Memeriksa apakah pilihan produk valid
            if (choice >= 1 && choice <= products.Count)
            {
                Product selectedProduct = products[choice - 1];

                // Meminta jumlah produk yang akan dibeli
                Console.Write($"Masukkan jumlah {selectedProduct.Name} yang ingin Anda beli: ");
                int quantity = Convert.ToInt32(Console.ReadLine());

                // Menghitung total harga
                double totalPrice = selectedProduct.Price * quantity;

                // Menampilkan ringkasan transaksi
                Console.WriteLine("\nRingkasan Transaksi:");
                Console.WriteLine("------------------------");
                Console.WriteLine($"Produk: {selectedProduct.Name}");
                Console.WriteLine($"Harga per unit: {selectedProduct.Price:N0} IDR");
                Console.WriteLine($"Jumlah: {quantity}");
                Console.WriteLine($"Total Harga: {totalPrice:N0} IDR");
                Console.WriteLine("------------------------");
                Pesan pesan = new Pesan();
                pesan.TampilkanPesan("Terima kasih telah berbelanja!");
            }
            else
            {
                Console.WriteLine("Maaf, nomor produk yang Anda pilih tidak valid.");
            }
        }

        static void DisplayProductList(List<Product> products)
        {
            Console.WriteLine("Daftar Produk:");
            Console.WriteLine("----------------");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i].Name} - {products[i].Price:N0} IDR");
            }
            Console.WriteLine("----------------");
        }
    }

    class Product
    {
        public string Name { get; }
        public double Price { get; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
