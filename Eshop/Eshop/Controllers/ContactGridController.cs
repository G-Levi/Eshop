using Eshop.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Eshop.Controllers
{
    public class ContactGridController : Controller
    {
        //// GET: ContactGrid
        //public ActionResult Index()
        //{
        //    return View();
        //}


        public ActionResult Index()
        {
            IList<Contact> contacts;

            using (var context = new ShoppingStoreDB())
            {
                contacts = context.Contacts.ToList();
            }

            return View(contacts);
        }

        public ActionResult Delete(int id)
        {
            using (var ctx = new ShoppingStoreDB())
            {
                var contact = ctx.Contacts.Find(id);
                if (contact != null)
                {
                    ctx.Contacts.Remove(contact);
                    ctx.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }
    }


}