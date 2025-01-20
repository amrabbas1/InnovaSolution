using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innova.Core.Models
{
    public class Parent : User
    {
        public int? StudentId { get; set; }//FK
        public ICollection<Student> Students { get; set; }
        public ICollection<PaymentInvoice> PaymentInvoices { get; set; }
    }
}
