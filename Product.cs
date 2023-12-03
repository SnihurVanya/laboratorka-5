using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5
{
    public class Product : ISearchable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Rating { get; set; }

        public Product(string name, decimal price, string description, string category, int rating)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"{Name} - {Price:C} - {Category} - Rating: {Rating}";
        }

        public bool SearchByPrice(decimal maxPrice)
        {
            return Price <= maxPrice;
        }

        public bool SearchByCategory(string category)
        {
            return Category.Equals(category, StringComparison.OrdinalIgnoreCase);
        }

        public bool SearchByRating(int minRating)
        {
            return Rating >= minRating;
        }
    }

}
