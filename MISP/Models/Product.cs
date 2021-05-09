using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Drawing;

namespace MISP
{
    public class Product : IProduct
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Bitmap Image { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public FoodCategories Category { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}