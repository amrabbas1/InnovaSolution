using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innova.Core.Models
{
    public class Achievement
    {
        public int? StudentId { get; set; }//FK
        public int? PackageId { get; set; }//FK
        public string AchievementType { get; set; }
        public string Icon { get; set; }
        public int Points { get; set; }
        public string Name { get; set; }
    }
}
