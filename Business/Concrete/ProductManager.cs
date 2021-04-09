using System.Collections.Generic;
using Business.Abstract;
using Entities.Concrete;
using DataAccess.Concrete.InMemory;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private InMemoryProductDal _inMemoryProductDal;
        
        public ProductManager(InMemoryProductDal inMemoryProductDal)
        {
            _inMemoryProductDal = inMemoryProductDal;
        }

        public List<Product> GetAll()
        {
            return _inMemoryProductDal.GetAll();
        }
    }
}