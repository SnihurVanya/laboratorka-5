using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5
{
    public class Order
    {
        public List<Product> Products { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }

        public Order(List<Product> products, int quantity)
        {
            Products = products;
            Quantity = quantity;
            TotalPrice = CalculateTotalPrice();
            Status = "Pending";
        }

        private decimal CalculateTotalPrice()
        {
            return Products.Sum(p => p.Price * Quantity);
        }

        public override string ToString()
        {
            return $"Order Total: {TotalPrice:C} - Status: {Status}";
        }
    }
}
