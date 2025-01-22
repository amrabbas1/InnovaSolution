using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innova.Core.Models
{
    public class Instructor : User
    {
        public string? AdminId { get; set; }//FK
        public int Specialization { get; set; }
        public int Experience_Years { get; set; }
        public int Rate { get; set; }
        public Admin Admin { get; set; }
        public List<Group> Groups { get; set; }

    }
}
