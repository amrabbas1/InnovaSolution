namespace Innova.Core.Models
{
    public class Session
    {
        public string Id { get; set; }
        public string Topic { get; set; }
        public DateTime Date { get; set; }
        public string Link { get; set; }
        public float Duration { get; set; }
        public string? GroupId { get; set; }//FK

        public Group Group { get; set; }
        public List<Note> Notes { get; set; }
        public List<Quiz> Quizzes { get; set; }
        public List<Material> Materials { get; set; }
        public List<Assignment> Assignments { get; set; }
        public List<StudentAttendSession> StudentAttendances { get; set; }
        
    }
}