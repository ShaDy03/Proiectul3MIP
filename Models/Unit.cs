using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Unit
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Type is required!")]
        public string Type { get; set; }
    }
}
