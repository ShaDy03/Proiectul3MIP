using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter your email")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Enter your password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "SexID is required!")]
        public int SexID { get; set; }

        [Required(ErrorMessage = "AddressID is required!")]
        public int AddressID { get; set; }

        [NotMapped]
        public string ConfirmPassword { get; set; }

        [ForeignKey("SexID")]
        public SexType SexType { get; set; }

        [ForeignKey("AddressID")]
        public Address Address { get; set; }
    }
}
