using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class SexType
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter your sex Male or Female")]
        public string Type { get; set; }

    }
}
