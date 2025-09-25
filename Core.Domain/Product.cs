namespace Core.Domain
{
    public class Product
    {
        public int Id { get; set; } // Primary key
        public string Name { get; set; } // Beschrijvende naam
        public bool ContainsAlcohol { get; set; } // Alcoholhoudend ja/nee
        public string ImageUrl { get; set; } // Path to the Foto (image)
        public int PackageId { get; set; } // Foreign key to Package
        public Package Package { get; set; } // Navigation property to Package
    }

}
