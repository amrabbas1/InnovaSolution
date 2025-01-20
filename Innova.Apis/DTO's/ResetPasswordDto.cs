using System.ComponentModel.DataAnnotations;

namespace Innova.Apis.DTO_s
{
	public class ResetPasswordDto
	{
		public string Email { get; set; }
		public string Token { get; set; }
		public string NewPassword { get; set; }
	}
}
