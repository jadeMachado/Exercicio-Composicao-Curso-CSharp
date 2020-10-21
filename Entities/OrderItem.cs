using System.Text;

namespace ComposicaoTres.Entities
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(Product product, double price, int quantity)
        {
            Product = product;
            Price = price;
            Quantity = quantity;

        }

        public double SubTotal(int quantity, double price)
        {
            return quantity * price;
        }



    }
}