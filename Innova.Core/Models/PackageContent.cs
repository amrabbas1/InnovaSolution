namespace Innova.Core.Models
{
    public class PackageContent
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int? PackageId { get; set; }//FK
        public Package Package { get; set; }
    }
}