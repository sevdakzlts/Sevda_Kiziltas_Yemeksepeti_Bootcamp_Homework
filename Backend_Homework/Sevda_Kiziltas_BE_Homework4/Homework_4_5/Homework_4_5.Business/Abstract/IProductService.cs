using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Homework_4_5.Core.Utilities.Result;
using Homework_4_5.Core.Utilities.Results;
using Homework_4_5.Entities.Concrete;

namespace Homework_4_5.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetList();
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);
        
    }
}
