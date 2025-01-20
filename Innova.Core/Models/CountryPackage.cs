using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innova.Core.Models
{
    public class CountryPackage
    {
        public int? CountryId { get; set; }//FK
        public int? PackageId { get; set; }//FK
        public int Price { get; set; }

    }
}
