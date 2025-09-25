using System.ComponentModel.DataAnnotations;

namespace Core.Domain
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string StudentNumber { get; set; }
        public string Email { get; set; }
        public string StudyCity { get; set; }
        public string PhoneNumber { get; set; }

        // Reference to User
        public int UserId { get; set; }
        public User User { get; set; }
    }

}

