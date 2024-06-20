// Repositories/ProductRepository.cs
using System.Collections.Generic;
using System.Linq;
using ProductAPI.Models;

namespace ProductAPI.Repositories
{
    public class ProductRepository
    {
        private readonly List<Product> _products = new List<Product>  {
            new Product { Id = 1, Name = "product a", Price = 100, Amount = 5 },
            new Product { Id = 2, Name = "product b", Price = 300, Amount = 100 },
            new Product { Id = 3, Name = "product c", Price = 100, Amount = 50 },
        };

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public void Add(Product product)
        {
            product.Id = _products.Count > 0 ? _products.Max(p => p.Id) + 1 : 1;
            _products.Add(product);
        }

        public void Update(Product product)
        {
            var existingProduct = GetById(product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
            }
        }

        public void Delete(int id)
        {
            var product = GetById(id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }
    }
}
