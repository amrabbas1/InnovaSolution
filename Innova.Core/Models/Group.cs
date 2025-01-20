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
        public int Id { get; set; }
        public string AgeGroup { get; set; }
        public int? InstructorId { get; set; }//FK
        public int? PackageId { get; set; }//FK

        public Instructor Instructor { get; set; }
        public Package Package { get; set; }
        public ICollection<GroupDate> GroupDates { get; set; }
        public ICollection<Session> Sessions { get; set; }
        public ICollection<GroupFile> GroupFiles { get; set; }

    }
}
