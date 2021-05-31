using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MISP.Controllers
{
    public class CartController : Controller
    {

        public ActionResult Index()
        {
            return View(GetCart().Lines);
        }

        

        public ActionResult ConfirmOrder()
        {
            return View();
        }

        public Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
    }

}