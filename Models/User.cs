using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public int SexID { get; set; }

        [NotMapped]
        public string ConfirmPassword { get; set; }

        [ForeignKey("SexID")]
        public SexType SexType { get; set; }

        public int AddressID { get; set; }

        [ForeignKey("AddressID")]
        public Address Address { get; set; }
    }
}
