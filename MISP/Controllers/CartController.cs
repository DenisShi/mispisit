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
            ViewBag.Total = GetCart().ComputeTotalValue();
            return View(GetCart().Lines);
        }

        

        public ActionResult ConfirmOrder()
        {
            ViewBag.Total = GetCart().ComputeTotalValue();
            return View(GetCart().Lines);
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