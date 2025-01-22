using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innova.Core.Models
{
    public class CountryPackage
    {
        public string? CountryId { get; set; }//FK
        public string? PackageId { get; set; }//FK
        public int Price { get; set; }
    }
}
