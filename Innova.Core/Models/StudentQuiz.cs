namespace Innova.Core.Models
{
    public class StudentQuiz
    {
        public int? StudentId { get; set; }//FK
        public int? QuizId { get; set; }//FK
        public float Score { get; set; }
        public string Feedback { get; set; }
    }
}