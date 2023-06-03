using DesafioEnumeracao.Entities;
using DesafioEnumeracao.Entities.Enums;
using System.Globalization;


namespace DesafioEnumeracao
{
    class Program
    {
        static void Main(string[] args)
        { 
            //informações do cliente
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY) : ");
            DateTime clientBirthDate = DateTime.Parse(Console.ReadLine());

            //instanciação do cliente na memória
            Client client = new Client(clientName, clientEmail, clientBirthDate);

            //informações do(s) pedido(s)
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            //instancia um pedido com cliente e status
            Order order = new Order(os, client);

            //informações de cada item do pedido e produto
            for (int i = 1;  i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(),(CultureInfo.InvariantCulture));
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                //instancia o produto
                Product product = new Product(productName, productPrice);
                //instancia o produto no pedido
                OrderItem item = new OrderItem(product, quantity);
                //associar os itens ao pedido
                order.AddItem(item);                            
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");                    
            Console.WriteLine(order);
            
           
            

        }
    }
}