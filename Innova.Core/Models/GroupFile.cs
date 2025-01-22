namespace Innova.Core.Models
{
    public class GroupFile
    {
        public string Id { get; set; }
        public string Path { get; set; }
        public string? GroupId { get; set; }//FK
        public Group Group { get; set; }
    }
}