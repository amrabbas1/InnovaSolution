using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innova.Core.Models
{
    public class Quiz
    {
        public string Id { get; set; }
        public string? SessionId { get; set; }//FK
        public Session Session { get; set; }
        public int Score { get; set; }
        public List<StudentQuiz> StudentQuizzes { get; set; }
    }
}
