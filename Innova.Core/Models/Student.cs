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
        public List<Achievement> Achievements { get; set; }
        public List<StudentQuiz> StudentsQuizzes { get; set; }
        public List<StudentProgram> StudentsPrograms { get; set; }
        public List<FinalProjectFile> FinalProjectFiles { get; set; }

    }
}
