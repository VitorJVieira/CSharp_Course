using Exercise03_Challenge.Entities;
using Exercise03_Challenge.Entities.Enum;

namespace Exercise03_Challenge {
    internal class Program {
        static void Main(string[] args) {
            
            
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client c1 = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            string status = Console.ReadLine();
            Console.Write("How many items to this order?");
            int n = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, Enum.Parse<OrderStatus>(status), c1);

            for (int i = 1;i <= n; i++) {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, price);
                OrderItem item = new OrderItem(quantity,price,product);
                order.addItem(item);
            }
            Console.WriteLine("");
            Console.WriteLine(order);
        }
    }
}