
namespace Core.Domain
{
    public class Package
    {
        public int Id { get; set; } // Primary key
        public List<Product> Products { get; set; } // Lijst van producten        public string Name { get; set; } // Beschrijvende naam

        public City City { get; set; } // Stad (as an Enum)
        public Canteen Canteen { get; set; } // Kantine (as an Enum)
        public DateTime PickupDateTime { get; set; } // Datum en tijdstip van ophalen
        public DateTime LastPickupDateTime { get; set; } // Tijdstip tot wanneer een pakket opgehaald kan worden
        public bool IsForAdultsOnly { get; set; } // Indicatie 18+
        public decimal Price { get; set; } // Prijs
        public MealType TypeOfMeal { get; set; } // Type maaltijd (as an Enum)
        public int? ReservedByStudentId { get; set; } // Gereserveerd door (foreign key)
        public Student ReservedBy { get; set; } // Navigation property
    }

    public enum City
    {
        Breda,
        DenBosch,
        Tilburg
    }

    public enum Canteen
    {
        Canteen1, // Add canteen names for each city
        Canteen2,
        // ... (based on the actual canteens available)
    }

    public enum MealType
    {
        Bread,
        WarmDinner,
        Drink,
        // ... (add more types as needed)
    }


}
