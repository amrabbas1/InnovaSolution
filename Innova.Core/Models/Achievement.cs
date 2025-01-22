using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innova.Core.Models
{
    public class Achievement
    {
        public string? StudentId { get; set; }//FK
        public string? PackageId { get; set; }//FK
        public string AchievementType { get; set; }
        public string Icon { get; set; }
        public int Points { get; set; }
        public string Name { get; set; }
    }
}
