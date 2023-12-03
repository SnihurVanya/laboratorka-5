using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5
{
    class Program
    {
        static void Main()
        {
            Store store = new Store();

            // Додавання користувача
            User user1 = new User("user1", "password1");
            store.AddUser(user1);

            // Додавання товару
            Product product1 = new Product("Laptop", 1200.0m, "High-performance laptop", "Electronics", 5);
            Product product2 = new Product("Smartphone", 800.0m, "Latest smartphone model", "Electronics", 4);
            store.AddProduct(product1);
            store.AddProduct(product2);

            // Виведення товарів у магазині
            store.DisplayProducts();

            // Створення списку товарів, які задовольняють критерії пошуку
            List<Product> searchResults = store.SearchProducts(new ProductSearchCriteria());
            Console.WriteLine("Search Results:");
            foreach (var result in searchResults)
            {
                Console.WriteLine(result);
            }

            // Покупка товарів
            store.ProcessOrder(user1, searchResults, 2);

            // Виведення історії покупок користувача
            Console.WriteLine($"{user1.Username}'s Purchase History:");
            foreach (var order in user1.PurchaseHistory)
            {
                Console.WriteLine(order);
            }

            // Виведення всіх замовлень у магазині
            store.DisplayOrders();
        }
    }

    // Клас для критеріїв пошуку товарів
    public class ProductSearchCriteria : ISearchable
    {
        public bool SearchByPrice(decimal maxPrice)
        {
            // Пошук за ціною
            return maxPrice >= 0; // У цьому прикладі просто повертає true, оскільки ціна завжди задовольняється
        }

        public bool SearchByCategory(string category)
        {
            // Пошук за категорією
            return string.IsNullOrEmpty(category) || category.Equals("Electronics", StringComparison.OrdinalIgnoreCase);
        }

        public bool SearchByRating(int minRating)
        {
            // Пошук за рейтингом
            return minRating <= 5; // У цьому прикладі просто повертає true, оскільки рейтинг завжди задовольняється
        }
    }
}
