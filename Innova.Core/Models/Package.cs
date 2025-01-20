namespace Innova.Core.Models
{
    public class Package
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public int? ProgramId { get; set; }//FK
        public Program Program { get; set; }
        public ICollection<PackageContent> PackagesContents { get; set; }
        public ICollection<CountryPackage> CountriesPackages { get; set; }
        public ICollection<OfferPackage> OffersPackages { get; set; }
        public ICollection<Achievement> Achievements { get; set; }


    }
}