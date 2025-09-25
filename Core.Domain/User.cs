namespace Core.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; } // Store hash, not plain-text!
        public string Role { get; set; } // "Student" or "Staff"
        // Relationships
        public Student Student { get; set; }
        public Staff Staff { get; set; }
    }

}
