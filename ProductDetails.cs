﻿using System.ComponentModel.DataAnnotations;

namespace DashboardNew.Models
{
	public class ProductDetails
	{
		[Key]
		public int Id { get; set; }
		public int ProductId { get; set; }

		public string Description { get; set; }

		public double Price { get; set; }

		public string Model { get; set; }

		public string Color { get; set; }

		public string Image { get; set; }
	}
}

	