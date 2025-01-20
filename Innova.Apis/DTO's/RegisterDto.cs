using System.ComponentModel.DataAnnotations;

namespace Innova.Apis.DTO_s
{
	public class RegisterDto
	{
		[Required(ErrorMessage = "Email is required.")]
		[EmailAddress(ErrorMessage = "Invalid email format.")]
		public string? Email { get; set; }

		[Required(ErrorMessage = "Student name is required.")]
		public string? StudentName { get; set; }

		[Required(ErrorMessage = "Phone number is required.")]
		[Phone(ErrorMessage = "Invalid phone number.")]
		public string? PhoneNumber { get; set; }

		[Required(ErrorMessage = "Password is required.")]
		[RegularExpression("(?=^.{6,100}$)(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[!@#$%&*()_+}]).*$",
			ErrorMessage = "Password must be between 6 and 100 characters and include at least 1 uppercase letter, 1 lowercase letter, 1 digit, and 1 special character.")]
		public string Password { get; set; }

		public string? PreferredLanguage { get; set; } = string.Empty;
		public string? TimeZone { get; set; } = string.Empty;
		public DateTime AppointmentDate { get; set; }
		public int Age { get; set; }
		public string? PaymentMethod { get; set; } = string.Empty;



	}
}

