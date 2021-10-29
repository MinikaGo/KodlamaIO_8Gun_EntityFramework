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

        public InMemoryProductDal()
        {
            _products = new List<Product> { 
                new Product{ProductId=1, CategoryId=1, ProductName="Bilgisayar", UnitPrice=2500, UnitsInStock=5},
                new Product{ProductId=2, CategoryId=1, ProductName="Notebook", UnitPrice=5000, UnitsInStock=1},
                new Product{ProductId=3, CategoryId=2, ProductName="Telefon", UnitPrice=5500, UnitsInStock=12},
                new Product{ProductId=4, CategoryId=2, ProductName="Kamera", UnitPrice=1250, UnitsInStock=5},
                new Product{ProductId=5, CategoryId=3, ProductName="Monitor", UnitPrice=3500, UnitsInStock=6},
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = null;
            productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.ProductId == categoryId).ToList();
        }

        public List<Product> GetListById(int id)
        {
            return _products.Where(p => p.ProductId == id).ToList();
        }

        public Product GetSingleById(int id)
        {
            return _products.SingleOrDefault(p => p.ProductId == id);
        }

        public void Update(Product product)
        {
            Product productToUpdate = null;
            productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            product.ProductId = productToUpdate.ProductId;
            product.CategoryId = productToUpdate.CategoryId;
            product.UnitPrice = productToUpdate.UnitPrice;
            product.UnitsInStock = productToUpdate.UnitsInStock;
            product.ProductName = productToUpdate.ProductName;
        }
    }
}
