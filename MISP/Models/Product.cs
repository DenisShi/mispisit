using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MISP
{
    public class Product : IProduct
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set ; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public virtual ICollection<FoodCategory> Categories { get; set; }
    }
}