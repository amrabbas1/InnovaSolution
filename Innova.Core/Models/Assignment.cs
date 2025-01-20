using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innova.Core.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public int? SessionId { get; set; }//FK
        public float Score { get; set; }
        public DateTime DeadLine { get; set; }
        public string Description { get; set; }
        public Session Session { get; set; }
        public ICollection<AssignmentFiles> AssignmentsFiles { get; set; }
        public ICollection<StudentAssignment> StudentsAssignments { get; set; }

    }
}
