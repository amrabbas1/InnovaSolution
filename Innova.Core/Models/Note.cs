namespace Innova.Core.Models
{
    public class Note
    {
        public int Id { get; set; }
        public int? SessionId { get; set; }
        public string Message { get; set; }
        public Session Session { get; set; }
    }
}