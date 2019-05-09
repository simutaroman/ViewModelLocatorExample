using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using ViewModelLocatorExample.Model;

namespace ViewModelLocatorExample.DAL
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
    }

    public class ProductRepository : IProductRepository
    {
        private static List<Product> _products;

        public List<Product> GetProducts()
        {
            if (_products == null)
            {
                LoadProducts();
            }

            return _products;
        }

        private void LoadProducts()
        {
            _products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Product 1"
                },
                new Product()
                {
                    Id=2,
                    Name = "Product 2"
                }
            };
        }

    }
}
