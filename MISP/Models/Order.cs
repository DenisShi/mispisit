using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections.Generic;

namespace MISP
{
    public class Order : IDomainObject
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IProduct> Products { get; set; }
        public DateTime TimeBegin { get; set; }
        public DateTime TimeArrival { get; set; }
        public DateTime TimeDeliver { get; set; }
        public int Persons { get; set; }
        public float Cost { get; set; }

        public OrderStatuses Status { get; set; }

        public Operator Operator
        {
            get => default;
            set
            {
            }
        }

        public IUser Client
        {
            get => default;
            set
            {
            }
        }

        public void Update()
        {
            Status = OrderStatuses.
        }
    }
}