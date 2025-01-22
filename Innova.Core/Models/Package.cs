namespace Innova.Core.Models
{
    public class Package
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string? ProgramId { get; set; }//FK
        public Program Program { get; set; }
        public List<PackageContent> PackagesContents { get; set; }
        public List<CountryPackage> CountriesPackages { get; set; }
        public List<OfferPackage> OffersPackages { get; set; }
        public List<Achievement> Achievements { get; set; }


    }
}