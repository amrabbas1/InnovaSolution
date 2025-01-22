using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innova.Core.Models
{
    public class Parent : User
    {
        public string? StudentId { get; set; }//FK
        public List<Student> Students { get; set; }
        public List<PaymentInvoice> PaymentInvoices { get; set; }
    }
}
