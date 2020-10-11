using ECommerce.Entities;
using System;

namespace ECommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(nome, email, birthDate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, client);
            Console.Write("How many itens to this order? ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product Name: ");
                string pname = Console.ReadLine();
                Console.Write("Product Price: ");
                double pprice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int pQuantity = int.Parse(Console.ReadLine());

                Product prod = new Product(pname, pprice);
                OrderItem orderitem = new OrderItem(pQuantity, pprice, prod);
                order.AddItem(orderitem);

            }
            

            Console.WriteLine("-------------");
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine("Order Moment: " + DateTime.Now);
            Console.WriteLine("Order Status: " + status);
            Console.WriteLine("Client: " + client);
            Console.WriteLine("ORDER ITEMS: ");
            foreach(OrderItem ord in order.Items)
            {
                Console.WriteLine(ord);
            }
            Console.WriteLine("The final Price is: " + order.Total());

        }
    }
}
