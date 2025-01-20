using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innova.Core.Services
{
	public interface IEmailService
	{
		Task SendPinEmailAsync(string email, int pinCode);
		Task SendResetPasswordEmailAsync(string email, string resetLink);
	}
}
