using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innova.Core.Models
{
	public class User : IdentityUser
	{

		public string? Name { get; set; }
		public int Age { get; set; }
		public string? PreferredLanguage { get; set; } 
		public string? TimeZone { get; set; } 
		public string? PaymentMethod { get; set; } 
		public DateTime AppointmentDate { get; set; } 
	}

}
