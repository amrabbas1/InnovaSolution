using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innova.Core.Models
{
    public class PromoCode
    {
        public string promoCode { get; set; }
        public bool IsActive { get; set; }
        public string? OfferId { get; set; }//FK

        public Offer Offer { get; set; }
    }
}
