using Innova.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innova.Core.Services
{

		public interface ITokenService
		{
		Task<string> GenerateToken(User user);

	}
}

