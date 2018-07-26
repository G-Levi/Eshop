using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eshop.Models; //statement(afirmatie) pt a vedea clasele din Models
using System.Data.Entity;
using System.Net;

namespace Eshop.Controllers
{
    public class CategoriesController : Controller
    {
        private List<Category> categorie;

        //private object Id_Category;

        //// GET: Categories
        //[HttpGet]
        //public ViewResult Categories()
        //{
        //    using (var ctx = new ShoppingStoreDB())
        //        return View(ctx.Set<Category>().OrderBy(model => model.Id_Category));

        //    // Has to be ordered in database query scenarios for paging to work!
        //}

        //private ViewResult View(object p)
        //{
        //    throw new NotImplementedException();
        //}

        //public ActionResult Index()
        //{
        //    var category = new List<Models.Category>
        //    {
        //        new Models.Category {Name = "Category1"},
        //        new Models.Category {Name = "Category2"},
        //        new Models.Category {Name = "Category3"}
        //    };
        //    return View(category);

        //}

        //public ActionResult BrowseCategory(string category)
        //{
        //    //string message = HttpUtility.HtmlEncode("showing category" + category); //HttpUtility.HtmlEncode reprezinta Convertește un string într-un șir HTML codificat.
        //    var categoryModel = new Models.Category { Name = category };
        //    return View(categoryModel);

        //}

        //public ActionResult Item()
        //{

        //    var item = new List<Item>
        //    {
        //        new Item {Id_Item = 1},
        //        new Item {Id_Item = 2},
        //        new Item {Id_Item = 3}
        //    };
        //    return View(item);

        //}

        //public ActionResult BrowseItem()
        //{
        //    var itemModel = new Item { Id_Item = 0 };
        //    return View(itemModel);
        //}



        //public ActionResult Categories()
        //{
        //    var category = new List<Models.Category>
        //    {
        //            new Models.Category {Name = "Category1"},
        //            new Models.Category {Name = "Category2"},
        //            new Models.Category {Name = "Category3"}
        //    };
        //    return View(category);
        //}
        public ActionResult Categories()
        {
            IList<Category> categories;

            using (var cat = new ShoppingStoreDB())
            {
                categorie = cat.Categories.ToList();
            }

            return View(categorie);
        }

        public ActionResult Delete(int id)
        {
            using (var categ = new ShoppingStoreDB())
            {
                var category = categ.Categories.Find(id);
                if (category != null)
                {
                    categ.Categories.Remove(category);
                    categ.SaveChanges();
                }
            }

            return RedirectToAction("Categories");
        }

        private ShoppingStoreDB edi = new ShoppingStoreDB();



        [HttpGet]
        public ActionResult Edit(int id)
        {
            Category category;

            if (id > 0)
            {
                using (var categ = new ShoppingStoreDB())
                {
                    category = categ.Categories.Find(id);
                }
            }
            else
            {
                category = new Category()
                {
                    Id_Category = id
                };
            }
            return View(category);

        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {

                using (var ctx = new ShoppingStoreDB())
                {
                    if (category.Id_Category > 0)
                    {
                        ctx.UpdateCategory(category);
                    }
                    else
                    {
                        ctx.Categories.Add(category);
                        ctx.SaveChanges();
                    }
                }

            }
            return RedirectToAction("Categories");
        }



        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                using (var ctx = new ShoppingStoreDB())
                {
                    ctx.Categories.Add(category);
                    ctx.SaveChanges();
                }
            }
            //return View(category);
            return RedirectToAction("Categories");
        }



    }

}
