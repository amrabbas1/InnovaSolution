namespace Innova.Core.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public DateTime Date { get; set; }
        public string Link { get; set; }
        public float Duration { get; set; }
        public int? GroupId { get; set; }//FK

        public Group Group { get; set; }
        public ICollection<Note> Notes { get; set; }
        public ICollection<Quiz> Quizzes { get; set; }
        public ICollection<Material> Materials { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
        public ICollection<StudentAttendSession> StudentAttendances { get; set; }
        
    }
}