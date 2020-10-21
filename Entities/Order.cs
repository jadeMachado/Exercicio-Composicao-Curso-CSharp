using System;
using System.Collections.Generic;
using System.Text;
using ComposicaoTres.Entities.Enums;

namespace ComposicaoTres.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        private List<OrderItem> Itens = new List<OrderItem>();
        public Client Client { get; set; }

        public Order(OrderStatus status, Client client)
        {
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Itens.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double total = 0;

            foreach (var item in Itens)
            {
                total += item.SubTotal(item.Quantity, item.Price);
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY: ");
            sb.AppendLine("Order momment: " + Moment);
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client.Name + " (" + Client.BirthDate + ") " + "- " + Client.Email);

            sb.AppendLine("ORDER ITEMS: ");
            foreach (var item in Itens)
            {
                sb.AppendLine(item.Product.Name + ", " + item.Product.Price + ", " + "Quantity: " + item.Quantity + ", " + "Subtotal: " + item.SubTotal(item.Quantity, item.Price));
            }

            sb.AppendLine("Total price: " + Total());

            return sb.ToString();
        }
    }
}