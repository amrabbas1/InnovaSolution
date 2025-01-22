using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innova.Core.Models
{
    public class Request
    {
        public string Id { get; set; }
        public string Reason { get; set; }
        public bool IsApproved { get; set; }
        public string Response { get; set; }
        public string? UserId { get; set; }//FK
        public User User { get; set; }
    }
}
