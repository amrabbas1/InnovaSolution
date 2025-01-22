namespace Innova.Core.Models
{
    public class Note
    {
        public string Id { get; set; }
        public string? SessionId { get; set; }
        public string Message { get; set; }
        public Session Session { get; set; }
    }
}