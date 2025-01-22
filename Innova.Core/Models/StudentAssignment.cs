using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innova.Core.Models
{
    public class StudentAssignment
    {
        public string? StudentId { get; set; }//FK
        public string? AssignmentId { get; set; }//FK
        public string FileUrl { get; set; }
        public List<StudentAssignmentFiles> StudentsAssingnmentsFiles { get; set; }
    }
}
