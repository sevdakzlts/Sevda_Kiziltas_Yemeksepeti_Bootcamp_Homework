using System;
using System.Collections.Generic;
using System.Text;
using Homework_4_5.Core.DataAccess.EntityFramework;
using Homework_4_5.DataAccess.Abstract;
using Homework_4_5.DataAccess.Concrete.EntityFramework.Contexts;
using Homework_4_5.Entities.Concrete;

namespace Homework_4_5.DataAccess.Concrete.EntityFramework
{
    public class EFProductDal : EFEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
    }
}
