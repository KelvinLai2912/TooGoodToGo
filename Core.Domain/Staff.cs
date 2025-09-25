using System.ComponentModel.DataAnnotations;

namespace Core.Domain
{
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StaffNumber { get; set; }
        public string Location { get; set; }

        // Reference to User
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
