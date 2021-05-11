using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MISP.Rerository
{
    public class UnitOfWork
    {
        public IRepository<Product> Products { set; get; } = new Repository<Product>();
    }
}