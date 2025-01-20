namespace Innova.Core.Models
{
    public class StudentProgram
    {
        public int? StudentId { get; set; }//FK
        public int? ProgramId { get; set; }//FK
        public string Feedback { get; set; }
        public int Score { get; set; }
        public ICollection<FinalProjectFile> FinalProjectFiles { get; set; }
    }
}