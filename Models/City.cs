using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Name is required!")]
        public string Name { get; set; }
    }
}
