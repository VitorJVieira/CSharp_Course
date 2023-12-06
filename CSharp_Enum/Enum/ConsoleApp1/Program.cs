using Course.Entities;
using Course.Entities.Enums;

namespace Course {
    internal class Program {
        static void Main(string[] args) {

            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString(); //enum to string

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); //string to enum

            Console.WriteLine(txt);
            Console.WriteLine(os);

        }
    }
}