using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager
    {
        IProductDal _carDal;

        public ProductManager(IProductDal carDal)
        {
            _carDal = carDal;
        }

        public List<Product> GetAll()
        {
            //İş Kodları
            //Yetkisi Var Mı ?

            return _carDal.GetAll();


        }
    }
}
