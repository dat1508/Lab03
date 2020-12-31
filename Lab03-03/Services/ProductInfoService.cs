using Lab03_03.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_03.Services
{
    class ProductInfoService
    {
        public static List<Order> GetAll()
        {
            List<Order> list = new List<Order>();
            using(var db = new DBProductInfo())
            {
                list = db.Orders.Include("Invoice").ToList();
            }
            return list;
        }
    }
}
