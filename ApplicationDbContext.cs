using DashboardNew.Models;
using Microsoft.EntityFrameworkCore;

namespace DashboardNew.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext()
		{

		}

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
		public void ConfigureServices(IServiceCollection services, DbContextOptionsBuilder options)
		{

		}

		public DbSet<Product> Products { get; set; }
		public DbSet<ProductDetails> ProductDetails { get; set; }
		public DbSet<Costumer> Costumer { get; set; }
		public DbSet<Invoice> Invoices { get; set; }
		public DbSet<PaymentAccept> PaymentAccept { get; set; }


	}
}
