using System;
using System.Collections.Generic;
using System.Text;
using Composition3.Entites;
using Composition3.Entites.Enums;
using System.Globalization;

namespace Composition3.Entites
{
    class Order
    {
        private DateTime Moment;
        private OrderStatus Status;
        private Client Client;
        private List<OrderItem> OrderItem = new List<OrderItem>(); 

        //Construtor Padrao
        public Order()
        {
        }

        //Construtor Modificado
        public Order(Client client,DateTime moment,OrderStatus status)
        {
            Client = client;
            Moment = moment;
            Status = status;
        }

        //Metodos
        public void AddItem(OrderItem orderItem)
        {
            OrderItem.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            OrderItem.Remove(orderItem);
        }

        public double Total()
        {
            double sum = 0;

            foreach (OrderItem obj in OrderItem)
            {
                sum += obj.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Order Summary: ");

            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));

            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());

            sb.Append("Client: ");
            sb.AppendLine(Client.ToString());
            

            sb.AppendLine("Order Item: ");

            foreach (OrderItem obj in OrderItem)
            {
                sb.AppendLine(obj.ToString());
            }

            sb.Append("Total price: " + Total().ToString("F2",CultureInfo.InvariantCulture));


            return sb.ToString();

        }
    }
    
}
