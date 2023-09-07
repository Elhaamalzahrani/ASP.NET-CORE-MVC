using Dashboard.Models;
using DashboardNew.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Controllers
{
	public class Store : Controller
	{
		public IActionResult AddProduct(Product product)
		{
			context.Product.Add(product);
			context.SaveChanges();
			return RedirectToAction("Index");

		}
		}

		[Authorize]
		public IActionResult Invoic(int id)
		{
			var user = HttpContext.User.Identity.Name;
			var cartsinvoice = _context.carts.SingleOrDefault(x => x.Id == id);
			var invoice = new Invoice()
			{
				CostumerId = user,
				ProductId = cartsinvoice.MyProductId,
				Color = cartsinvoice.Color,
				price = cartsinvoice.Price,
				ProductName = cartsinvoice.ProductName,
				Capacity = cartsinvoice.Capacity,
				Total = cartsinvoice.Total,
			};
			_context.Invoice.Add(invoice);
			_context.SaveChanges();

			return View(invoice);
		}

		//var ProductDetails = _context.ProductDetails.Where(p => p.ProductId == id).ToList();
		//return View(ProductDetails);



		[Authorize]
		public IActionResult Checkout(int id)
		{
			var user = HttpContext.User.Identity.Name;
			var ProductDetails = _context.ProductDetails.SingleOrDefault(p => p.ProductId == id);
			var cart = new Cart()
			{
				IdCustomer = user,
				ProductId = productDetails.ProductId,
				Color = productDetails.Color,
				Image = productDetails.Image,
				Price = productDetails.Price,
				Total = productDetails.Price * (15 / 100) + productDetails.Price,
				ProductName = productDetails.ProductName,
				Tax = 0.15
			};
			_context.Cart.Add(cart);
			_context.SaveChanges();
			return View(cart);

		}
		public IActionResult Index()
		{
			var Product = _context.Products.ToList();
			return View(Product);
		}
	}
}