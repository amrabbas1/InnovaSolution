using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innova.Core.Models
{
    public class Material
    {
        public int Id { get; set; }
        public int? SessionId { get; set; }//FK
        public Session Session { get; set; }
        public string FileUrl { get; set; }
    }
}
