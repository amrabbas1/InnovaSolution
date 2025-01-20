using System.ComponentModel.DataAnnotations;

namespace Innova.Apis.DTO_s
{
	public class ForgetPasswordDto
	{
		[Required]
		[EmailAddress]
		public string Email { get; set; }
	}

}
