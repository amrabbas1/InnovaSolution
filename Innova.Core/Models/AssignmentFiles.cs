namespace Innova.Core.Models
{
    public class AssignmentFiles
    {
        public int Id { get; set; }
        public int? AssignmentId { get; set; }//FK
        public string FileUrl { get; set; }
        public Assignment Assignment { get; set; }
    }
}