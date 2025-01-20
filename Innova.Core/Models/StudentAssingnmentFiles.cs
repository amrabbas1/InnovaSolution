using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innova.Core.Models
{
    public class StudentAssingnmentFiles
    {
        public int? StudentId { get; set; }
        public int? AssignmentId { get; set; }
        public string FileUrl { get; set; }
        public ICollection<StudentAssignment> StudentsAssignments { get; set; }
    }
}
