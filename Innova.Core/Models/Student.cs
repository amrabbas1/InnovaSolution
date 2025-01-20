using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innova.Core.Models
{
    public class Student : User
    {
        public string Grade { get; set; }
        public string SchoolName { get; set; }
        public ICollection<Achievement> Achievements { get; set; }
        public ICollection<StudentQuiz> StudentsQuizzes { get; set; }
        public ICollection<StudentProgram> StudentsPrograms { get; set; }
        public ICollection<FinalProjectFile> FinalProjectFiles { get; set; }

    }
}
