using System.ComponentModel.DataAnnotations;

namespace DashboardNew.Models
{
	public class PaymentAccept
	{

		[Key]
		public int Id { get; set; }
		[Required]
		public string payment { get; set; }
	}
}
