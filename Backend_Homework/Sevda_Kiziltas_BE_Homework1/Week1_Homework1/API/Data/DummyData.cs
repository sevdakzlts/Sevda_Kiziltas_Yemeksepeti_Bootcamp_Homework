using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Data
{
    public class DummyData
    {
        private const string ProductName = "Product_Name {0}";
        
        public List<Product> Products = new List<Product>();

        private static readonly Lazy<DummyData> lazy = new Lazy<DummyData>(() => new DummyData());

        public static DummyData Instance
        {
            get
            {
             /*   if (lazy.IsValueCreated)
                {
                  Console.WriteLine("");
                } */
                return lazy.Value;
            }
        }

        private DummyData()
        {
            FillData();
        }

        private void FillData()
        {
            Random r = new Random();
            for (int i = 0; i < 12; i++)
            {
                Products.Add(new Product()
                {
                    Id = Products.Count,
                    Name = string.Format(ProductName, i),
                    Price = r.Next(1, 10) * i
                });
            }
        }

    }
}
