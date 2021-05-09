using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections.Generic;

namespace MISP
{
    public class Cart
    {
        public List<CartLine> LineCollection { get; set; }
        public void AddItem(Product product, int quantity)
        {

        }
        public void RemoveLine(Product product)
        {

        }

        public decimal ComputeTotalValue()
        {
            return 0;
        }
        public void Clear()
        {

        }
    }
}