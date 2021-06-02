using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace MISP
{
    public class Operator : IDomainObject
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get; set; }
        public string Phone { get; set; }

        public void TakeOrder(Order order)
        {

        }

        public void UpdateOrder(Order order)
        {

        }
        public void SendOrder(Order order)
        {

        }

        public void CancelOrder(Order order)
        {

        }
    }
}