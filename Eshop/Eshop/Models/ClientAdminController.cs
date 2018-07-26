//using System.Data;
//using System.Linq;
//using System.Web.Mvc;

//namespace Eshop.Controllers
//{
//    public class ProductController : Controller
//    {

//        public ActionResult UpdateProducts(int? multiplier)
//        {
//            if (multiplier != null)
//            {
//                ViewBag.RowsAffected = ProductRepository.UpdateProducts(multiplier.Value);
//            }
//            return View();
//        }

//        // GET: /Product/

//        public ActionResult Product(int? SelectedProduct)
//        {
//            var products = ProductRepository.Get(
//                orderBy: q => q.OrderBy(d => d.Name));
//            ViewBag.Selected = new SelectList(products, "ProductID", "Name", Selected);
//            return View();
//        }



//    }
//}


