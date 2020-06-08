using System;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kochka.Models;

namespace kochka.Controllers
{
    public class HomeController : Controller
    {
        TicketContext db = new TicketContext();
        public ActionResult Index()
        {
            return View(db.Tickets.ToList());
           
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.TicketId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Entry(purchase).State = EntityState.Modified;
            db.SaveChanges();
            return purchase.Person+", спасибо за покупку!";
        }
       
        public ActionResult Contact()
        {
            return View();

        } 
        public ActionResult Customers()
        {
            return View(db.Purchases.ToList());

        }
    

    }
}