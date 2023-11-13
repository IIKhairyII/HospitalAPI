using System.ComponentModel.DataAnnotations;

namespace API.Models.Common
{
    public class CommonInfo
    {
        [Required]
        public int Key { get; set; }
        [Required, MaxLength(30)]
        public string ID { get; set; }
        [Required, MaxLength(10)]
        public string FirstName { get; set; }
        [Required, MaxLength(10)]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required, MaxLength(20)]
        public string PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
    }
}
