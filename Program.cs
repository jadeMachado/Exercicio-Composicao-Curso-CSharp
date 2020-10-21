using System;
using ComposicaoTres.Entities;
using ComposicaoTres.Entities.Enums;

namespace ComposicaoTres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Birth date (DD/M/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.WriteLine("How many items to this order? ");
            int quantidade = int.Parse(Console.ReadLine());

            Order order = new Order(status, client);

            for (int i = 1; i <= quantidade; i++)
            {

                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Product product = new Product(productName, productPrice);
                Console.Write("Quantity: ");
                int productQuantidade = int.Parse(Console.ReadLine());

                order.AddItem(new OrderItem(product, productPrice, productQuantidade));

            }

            Console.WriteLine(order);

        }
    }
}
