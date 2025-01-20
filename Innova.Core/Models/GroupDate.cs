namespace Innova.Core.Models
{
    public class GroupDate
    {
        public int Id { get; set; }
        public int? GroupId { get; set; }//FK
        public DateTime Date { get; set; }

        public Group Group { get; set; }
    }
}