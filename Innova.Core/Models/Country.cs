﻿namespace Innova.Core.Models
{
    public class Country
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public List<CountryPackage> CountriesPackages { get; set; }
    }
}