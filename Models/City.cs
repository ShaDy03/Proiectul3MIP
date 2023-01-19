using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Enter your city where are you frome")]
        public string Name { get; set; }
    }
}
