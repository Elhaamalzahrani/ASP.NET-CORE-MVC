using DashboardNew.Data;
using DashboardNew.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DashboardNew.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly ApplicationDbContext context;


		public HomeController(ApplicationDbContext context)
		{
			this.context = context;
		}

		public IActionResult Index()
		{
			var product = context.Products.ToList();
			return View(product);
		}

		public IActionResult AddProduct(Product product)
		{
			context.Products.Add(product);
			context.SaveChanges();
			return RedirecttoAction("Index");
		}


			public ApplicationDbContext GetContext()
		{
			return context;
		}
		public IActionResult Edit(int id)
		{
			var product = context.Products.SingleOrDefault(p => p.Id == id);


			return View(product);

		}
		public IActionResult UpdataProduct(Product product)
		{
			context.Products.Update(product);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult Delete(int id)
		{
			var product = context.Products.SingleOrDefault(p => p.Id == id);
			if (product != null)
			{
				context.Products.Remove(product);
				context.SaveChanges();
				
			}
			return RedirecttoAction("Index");
		}

		private IActionResult RedirecttoAction(string v)
		{
			throw new NotImplementedException();
		}

		


		public IActionResult CreatNewProduct(Product product)
		{
			context.Products.Add(product);
			context.SaveChanges();
			return RedirecttoAction("Index");
		}

		public IActionResult ProductDetails()
		{
			var product = context.Products.ToList();
			return View();
		}




		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}

