using DesafioEnumeracao.Entities.Enums;
using System.Text;
using System.Globalization;
namespace DesafioEnumeracao.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(OrderStatus status, Client client)
        {
            Moment = DateTime.Now;
            Status = status;
            Client = client;

        }

        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }
        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in OrderItems)
            {
                sum += item.subTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString());
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in OrderItems)
            {
                sb.AppendLine(item.ToString());
                
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
