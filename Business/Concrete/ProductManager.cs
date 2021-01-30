using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        IProductDal _productDal;
        public List<Product> GetAll()
        {
            //İş kodları
            return _productDal.GetAll();
            
        }
    }
}
