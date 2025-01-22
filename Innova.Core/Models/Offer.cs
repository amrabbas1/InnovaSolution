using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innova.Core.Models
{
    public class Offer
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public float Discount { get; set; }
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Title { get; set; }
        public List<PromoCode> PromoCodes { get; set; }
        public List<OfferPackage> OffersPackages { get; set; }


    }
}
