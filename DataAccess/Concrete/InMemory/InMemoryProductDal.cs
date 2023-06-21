using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        List<Category> _categories;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Kamera",UnitPrice=150,UnitsInStock=10},
                new Product{ProductId=2,CategoryId=2, ProductName="Mouse", UnitsInStock=50,UnitPrice=5},
                new Product{ProductId=3,CategoryId=3, ProductName="Ekran", UnitsInStock = 120,UnitPrice=15},
                new Product{ProductId=4,CategoryId=4,ProductName="Hdmi",UnitsInStock=20,UnitPrice=30}
            };    
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            var delete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(delete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();

        }

        public void Update(Product product)
        {
            var update = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            update.ProductId = product.ProductId;
            update.CategoryId = product.CategoryId;
            update.ProductName = product.ProductName;
            update.UnitPrice = product.UnitPrice;
            update.UnitsInStock = product.UnitsInStock;
        }
    }
}
