using System.ComponentModel.DataAnnotations;

namespace DashboardNew.Models
{
	public class Product
	{
		[Key]
			public int Id { get; set; }
			public  string ProductName { get; set; }
			public double Price { get; set; }
		}
	}




