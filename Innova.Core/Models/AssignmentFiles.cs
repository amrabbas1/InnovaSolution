namespace Innova.Core.Models
{
    public class AssignmentFiles
    {
        public string Id { get; set; }
        public string? AssignmentId { get; set; }//FK
        public string FileUrl { get; set; }
        public Assignment Assignment { get; set; }
    }
}