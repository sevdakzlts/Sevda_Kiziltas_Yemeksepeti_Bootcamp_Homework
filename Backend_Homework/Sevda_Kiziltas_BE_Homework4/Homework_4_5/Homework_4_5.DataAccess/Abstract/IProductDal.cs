using System;
using System.Collections.Generic;
using System.Text;
using Homework_4_5.Core.DataAccess;
using Homework_4_5.Entities.Concrete;

namespace Homework_4_5.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {

    }
}
