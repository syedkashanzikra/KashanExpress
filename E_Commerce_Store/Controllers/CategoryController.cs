
using KashanExpress.ContextFiles;    
using KashanExpress.DataAccessLayer.Infrastructure.IReposatory;
using KashanExpress.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using KashanExpress.DataAccessLayer.Infrastructure.Reposatory;

namespace E_Commerce_Store.Controllers
{
    public class CategoryController : Controller
    {
        private IUnitofWork _unitofWork;
        public CategoryController(IUnitofWork unitofWork) {
			_unitofWork = unitofWork;
        
        }
        // GET: CategoryController
        //Selet*From Category
        [Route("/Category")]
        public ActionResult ViewCategory()
        {
            IEnumerable<Category> categories = _unitofWork.Category.GetAll();
            return View(categories);
        }

       

        // GET: CategoryController/Create
        [Route("/Create/Category")]
        public ActionResult CreateCategory()
        {
            return View(); 
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Create/Category")]
        public ActionResult CreateCategory(Category category)
        {
            
            if (ModelState.IsValid)
            {
				_unitofWork.Category.Add(category);
				_unitofWork.Save();
                return RedirectToAction("ViewCategory");

            }
           
                return View(category);

            
            //try
            //{
            //    return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
            //    return View();
            //}
        }

        // GET: CategoryController/Edit/5
        public ActionResult EditCategory(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var category = _unitofWork.Category.GetT(x=>x.ID == id);
            if (category == null)
            {
                return NotFound();

            }
            return View(category);
            
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCategory(Category category)
        {
            if (ModelState.IsValid)
            {
				_unitofWork.Category.Update(category);
				_unitofWork.Save();
                return RedirectToAction("ViewCategory");
            }

            return View(category);

        }

        // GET: CategoryController/Delete/5
        public ActionResult DeleteCategory(int? id)
        {
            if(id==null || id == 0)
            {
                return NotFound();  
            }

            var category = _unitofWork.Category.GetT(x => x.ID == id);
			if (category == null)
            {
                return NotFound();

            }
            return View(category);
        }

        // POST: CategoryController/Delete/5
        
        [HttpPost, ActionName("DeleteCategory")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteCategoryData(int id)
        {
           var category = _unitofWork.Category.GetT(x => x.ID == id);
            if(category == null)
            {
                return BadRequest();
            }
			_unitofWork.Category.Delete(category);
			_unitofWork.Save();

            return RedirectToAction("Dashboard","Admin");

            //We can also do that  return RedirectToAction("Action Name","Controller NAme");


        }
    }
}
