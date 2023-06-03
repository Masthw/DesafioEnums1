
using System.Globalization;

namespace DesafioEnumeracao.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }

        public OrderItem()
        {
        }
        public OrderItem(Product product, int quantity)

        {
            Name = product.Name;
            Price = product.Price;
            Quantity = quantity;
          

        }
        public double subTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return 
               Name + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture) + ", Quantity: " + Quantity + ", Subtotal: $" + subTotal().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
