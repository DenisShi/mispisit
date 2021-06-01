using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Drawing;
using System.Collections.Generic;

namespace MISP
{
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set ; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public virtual ICollection<FoodCategory> Categories { get; set; }
    }
}