using Exercise02.Entities;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.Write("Common, used ou imported (c/u/i)?" );
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                int price = int.Parse(Console.ReadLine());
                
                if (c == 'i') {
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine());

                    products.Add(new ImportedProduct(name, price, customFee));
                } else if (c == 'u') {
                    Console.Write("Manufacture date (dd/mm/yyyy): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, date));
                } else {
                    products.Add(new Product(name, price));
                }

                
            }

            Console.WriteLine("");
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product product in products) {
                Console.WriteLine(product.priceTag());
            }
        }
    }
}