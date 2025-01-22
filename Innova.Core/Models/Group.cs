using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Innova.Core.Models
{
    public class Group
    {
        public string Id { get; set; }
        public string AgeGroup { get; set; }
        public string? InstructorId { get; set; }//FK
        public string? PackageId { get; set; }//FK

        public Instructor Instructor { get; set; }
        public Package Package { get; set; }
        public List<GroupDate> GroupDates { get; set; }
        public List<Session> Sessions { get; set; }
        public List<GroupFile> GroupFiles { get; set; }

    }
}
