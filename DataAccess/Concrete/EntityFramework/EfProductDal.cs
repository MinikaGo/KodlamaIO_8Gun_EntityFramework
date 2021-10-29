using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return new List<Product> {
                new Product { ProductId = 6, CategoryId = 2, ProductName = "TShirt", UnitPrice = 60, UnitsInStock = 2018 },
                new Product { ProductId = 6, CategoryId = 2, ProductName = "Pantolon", UnitPrice = 60, UnitsInStock = 2018 }

            };
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetListById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Product GetSingleById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
