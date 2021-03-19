using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Homework_4_5.Business.Abstract;
using Homework_4_5.Core.Utilities.Result;
using Homework_4_5.Core.Utilities.Results;
using Homework_4_5.DataAccess.Abstract;
using Homework_4_5.Entities.Concrete;

namespace Homework_4_5.Business.Concrete
{
    public class ProductService : IProductService
    {
        private IProductDal _productDal;

        public ProductService(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult("Product Added successfully");
        }

        public IResult Delete(Product product)
        {
           _productDal.Delete(product);
           return new SuccessResult("Product Deleted successfully");
        }

        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList().ToList()); 
        }


        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult("Product Updated successfully");
        }
    }
}
