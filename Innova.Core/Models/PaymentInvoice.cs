using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innova.Core.Models
{
    public class PaymentInvoice
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public int? ParentId { get; set; }//FK

        public Parent Parent { get; set; }
    }
}
