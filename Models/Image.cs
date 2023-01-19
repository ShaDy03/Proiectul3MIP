using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Source is required!")]
        public string Source { get; set; }
    }
}
