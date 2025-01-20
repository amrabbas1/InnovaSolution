using System.ComponentModel.DataAnnotations;

namespace Innova.Apis.DTO_s
{

		public class LoginDto
		{
		[Required]
		public string Email { get; set; }
		[Required]
		public string Password { get; set; }

	}

	
}
