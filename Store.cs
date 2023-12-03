using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5
{
    public class Store
    {
        public List<User> Users { get; set; }
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }

        public Store()
        {
            Users = new List<User>();
            Products = new List<Product>();
            Orders = new List<Order>();
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void DisplayProducts()
        {
            Console.WriteLine("Available Products:");
            foreach (var product in Products)
            {
                Console.WriteLine(product);
            }
        }

        public void DisplayOrders()
        {
            Console.WriteLine("All Orders:");
            foreach (var order in Orders)
            {
                Console.WriteLine(order);
            }
        }

        public void ProcessOrder(User user, List<Product> selectedProducts, int quantity)
        {
            Order order = new Order(selectedProducts, quantity);
            user.PurchaseHistory.Add(order);
            Orders.Add(order);
            Console.WriteLine("Order processed successfully!");
        }

        public List<Product> SearchProducts(ISearchable criteria)
        {
            return Products.Where(p => criteria.SearchByPrice(p.Price) && criteria.SearchByCategory(p.Category) && criteria.SearchByRating(p.Rating)).ToList();
        }
    }
}