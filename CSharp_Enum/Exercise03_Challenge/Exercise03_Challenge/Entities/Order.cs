using Exercise03_Challenge.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03_Challenge.Entities {
    internal class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client) {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void addItem(OrderItem item) {
            Items.Add(item);
        }

        public void removeItem(OrderItem item) { 
            Items.Remove(item); 
        }

        public double Total() {
            double sum = 0;
            foreach (OrderItem item in Items) {
                sum += item.subTotal();
            }
            return sum;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY: ");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("(dd/MM/yyyy)"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" (");
            sb.Append(Client.birthDate.ToString("dd/MM/yyyy"));
            sb.Append(") - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order items: ");
            foreach (OrderItem item in Items) {
                sb.Append(item.Product.Name);
                sb.Append(", $");
                sb.Append(item.Product.Price);
                sb.Append(", Quantity: ");
                sb.Append(item.Quantity);
                sb.Append(", Subtotal: $");
                sb.AppendLine(item.subTotal().ToString());
            }
            sb.Append("Total price: $");
            sb.Append(Total());
            return sb.ToString();
        }
    }
}
