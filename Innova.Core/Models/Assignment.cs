using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innova.Core.Models
{
    public class Assignment
    {
        public string Id { get; set; }
        public string? SessionId { get; set; }//FK
        public float Score { get; set; }
        public DateTime DeadLine { get; set; }
        public string Description { get; set; }
        public Session Session { get; set; }
        public List<AssignmentFiles> AssignmentsFiles { get; set; }
        public List<StudentAssignment> StudentsAssignments { get; set; }

    }
}
