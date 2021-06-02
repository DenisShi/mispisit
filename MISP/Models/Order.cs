using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections.Generic;
using MISP.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MISP
{
    public class Order : IDomainObject
    {
        public int Id { get; set; }
        public ICollection<OrderLine> Products { get; set; }
        public DateTime? TimeBegin { get; set; }
        public DateTime TimeArrival { get; set; }
        public DateTime? TimeDeliver { get; set; }
        public int? Persons { get; set; }
        public float Cost { get; set; }

        public OrderStatuses Status { get; set; }

        public Operator Operator { get; set; }

        public IUser Client { get; set; }

        public Order()
        {
            Products = new List<OrderLine>();
        }

        public void Update()
        {
            //Status = OrderStatuses.

        }
        public void SetProducts(List<CartLine> cartlines)
        {
            foreach (CartLine cl in cartlines)
            {
                Products.Add(new OrderLine 
                {
                    ProductId = cl.Product.Id,
                    Product = cl.Product,
                    Quantity = cl.Quantity
                });
            }
        }
    }
    public class OrderLine : IDomainObject
    {
        [Key]
        public int Id { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //[ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product;
        public int Quantity { get; set; }
    }
}