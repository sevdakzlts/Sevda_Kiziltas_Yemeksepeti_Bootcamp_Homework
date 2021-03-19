using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Homework_4_5.Business.Abstract;
using Homework_4_5.Business.Concrete;
using Homework_4_5.DataAccess.Abstract;
using Homework_4_5.DataAccess.Concrete.EntityFramework;

namespace Homework_4_5.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<EFProductDal>().As<IProductDal>();
        }
    }
}
