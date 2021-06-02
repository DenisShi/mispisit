using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MISP.Rerository;

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

        //Переделать, срочно
        [HttpPost]
        public ActionResult ConfirmOrder(string name, string phone, string address, string persons)
        {
            Order order = new Order()
            {
                Cost = Convert.ToSingle(GetCart().ComputeTotalValue()),
                Persons = Convert.ToInt32(persons),
                Status = OrderStatuses.Created,
                TimeArrival = DateTime.Now
            };
            AnonUser user = new AnonUser() 
            {
                Id = order.Id,
                Name = name, 
                Address = address,
                Phone = phone,
                Order = order
            };
            order.Client = user;
            order.SetProducts(GetCart().Lines);
            using (Context db = new Context())
            {
                db.Orders.Add(order);
                db.AnonUser.Add(user);
                db.SaveChanges();
            }

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

        public ActionResult Test()
        {
            Order ord;
            using (Context db = new Context())
            {
                ord = db.Orders.Find(1);
            }

            return View(GetCart().Lines);
        }
    }

}