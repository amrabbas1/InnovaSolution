namespace Innova.Core.Models
{
    public class StudentQuiz
    {
        public string? StudentId { get; set; }//FK
        public string? QuizId { get; set; }//FK
        public float Score { get; set; }
        public string Feedback { get; set; }
    }
}