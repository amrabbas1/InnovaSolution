namespace Innova.Core.Models
{
    public class GroupFile
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public int? GroupId { get; set; }//FK

        public Group Group { get; set; }
    }
}