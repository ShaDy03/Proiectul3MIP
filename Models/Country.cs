using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter your country where are you from")]
        public string Name { get; set; }
    }
}
