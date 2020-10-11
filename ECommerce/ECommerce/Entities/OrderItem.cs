using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            double subTotal = Quantity * Price;
            return subTotal;
        }

        public override string ToString()
        {
            return ("Product: " + Product + ", Price: " + Price + ", Quantity: " + Quantity +", Subtotal: "+ SubTotal());
        }
    }
}
