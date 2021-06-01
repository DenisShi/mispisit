using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MISP;

namespace MISP.Models
{
    public class OrderProductRelation : IDomainObject
    {
        public int Id { get; set; }
        public int productId { get; set; }
        public OrderProductRelation(Product product)
        {
            productId = product.Id;
        }
    }
}