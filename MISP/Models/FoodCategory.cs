using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MISP
{
    public class FoodCategory : IDomainObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}