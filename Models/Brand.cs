using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter the brand you want to buy")]
        public string Name { get; set; }
    }
}
