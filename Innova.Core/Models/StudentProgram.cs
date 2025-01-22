namespace Innova.Core.Models
{
    public class StudentProgram
    {
        public string? StudentId { get; set; }//FK
        public string? ProgramId { get; set; }//FK
        public string Feedback { get; set; }
        public int Score { get; set; }
        public List<FinalProjectFile> FinalProjectFiles { get; set; }
    }
}