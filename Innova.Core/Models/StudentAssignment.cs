using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innova.Core.Models
{
    public class StudentAssignment
    {
        public int? StudentId { get; set; }//FK
        public int? AssignmentId { get; set; }//FK
        public string FileUrl { get; set; }
    }
}
