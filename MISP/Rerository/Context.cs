using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MISP.Rerository
{
    public class Context : DbContext
    {
        public Context() : base("DbConnection") { }

        public DbSet<Product> Products { set; get; }

    }
}