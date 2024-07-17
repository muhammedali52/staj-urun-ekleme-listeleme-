using System.Collections.Generic;
using System.Linq;


namespace staj.Models
{
    public class ProductRepository
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1500 },
            new Product { Id = 2, Name = "Smartphone", Price = 800 },
            new Product { Id = 3, Name = "Tablet", Price = 500 }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public void AddProduct(Product product)
        {
            product.Id = products.Max(p => p.Id) + 1;
            products.Add(product);
        }
    }
}
