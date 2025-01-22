namespace Innova.Core.Models
{
    public class GroupDate
    {
        public string Id { get; set; }
        public string? GroupId { get; set; }//FK
        public DateTime Date { get; set; }

        public Group Group { get; set; }
    }
}