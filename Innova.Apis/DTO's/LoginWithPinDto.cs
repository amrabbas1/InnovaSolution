using System.ComponentModel.DataAnnotations;

namespace Innova.Apis.DTO_s
{
	public class LoginWithPinDto
	{
		[Required(ErrorMessage = "Email is required.")]
		[EmailAddress(ErrorMessage = "Invalid email format.")]
		public string Email { get; set; }

		[Required(ErrorMessage = "PIN is required.")]
		[Range(1000, 9999, ErrorMessage = "PIN must be a 4-digit number.")]
		public int PinCode { get; set; }
	}
}
