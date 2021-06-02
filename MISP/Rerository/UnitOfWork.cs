using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MISP.Rerository
{
    public class UnitOfWork
    {
        public Context _context = new Context();
        public UnitOfWork()
        {
            Products = new Repository<Product>(_context);
            Orders = new Repository<Order>(_context);
            AnonUsers = new Repository<AnonUser>(_context);
        }
        public IRepository<Product> Products { set; get; }
        public IRepository<Order> Orders { set; get; }
        public IRepository<AnonUser> AnonUsers { set; get; } 
    }
}