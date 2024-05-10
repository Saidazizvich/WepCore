using Microsoft.AspNetCore.Mvc;
using WepCore.Models.Context;
using WepCore.Models.Entities;

namespace WepCore.Controllers
{
	public class CategoryController : Controller
	{
		private readonly CoreContext _coreContext;

		public CategoryController(CoreContext coreContext)
		{
			_coreContext = coreContext;
		}

		public IActionResult Index()
		{
			var list = _coreContext.Categories.ToList();
			return View(list);
		}

		[HttpGet]
		public IActionResult GetCategory() 
		{
			return View();
		}

		[HttpPost]
		public IActionResult GetCategory(Category category)
		{
			_coreContext.Categories.Add(category);	
			_coreContext.SaveChanges();	

			return RedirectToAction("Index");	
		}

		public IActionResult Update(int id)
		{
			return View(_coreContext.Categories.Find(id));
		}

		[HttpPost]
		public IActionResult Update(Category category)
		{
			var updateId = _coreContext.Categories.Find(category.Id);
			updateId.CategoryName = category.CategoryName;
			updateId.Descripation = category.Descripation;
			updateId.ModefiedDate = category.ModefiedDate;

			_coreContext.SaveChanges();
			return RedirectToAction("Index");
		}  

		public IActionResult Delete(int id) 
		{
			var delete = _coreContext.Categories.FirstOrDefault(x=>x.Id == id);	

			_coreContext.Remove(delete);
			_coreContext.SaveChanges();

			return RedirectToAction("Index");
		}
	}
}
