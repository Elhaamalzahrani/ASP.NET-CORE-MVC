using System.ComponentModel.DataAnnotations;

namespace DashboardNew.Models
{
	public class Costumer
	{

		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string EmailAddress { get; set; }
		public string PhoneNumber { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string Region { get; set; }

	}
}
