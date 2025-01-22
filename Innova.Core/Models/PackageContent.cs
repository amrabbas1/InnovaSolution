namespace Innova.Core.Models
{
    public class PackageContent
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public string? PackageId { get; set; }//FK
        public Package Package { get; set; }
    }
}