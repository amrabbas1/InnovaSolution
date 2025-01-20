using System.ComponentModel.DataAnnotations;

namespace Innova.Apis.DTO_s
{
	public class RequestPinDto
	{
		[Required(ErrorMessage = "Email is required.")]
		[EmailAddress(ErrorMessage = "Invalid email format.")]
		public string Email { get; set; }
	}
}