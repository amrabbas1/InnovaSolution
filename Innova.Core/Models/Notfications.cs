using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innova.Core.Models
{
    public class Notfications
    {
        public int Id { get; set; }
        public int? UserId { get; set; }//FK
        public string Message { get; set; }
        public User User { get; set; }
    }
}
