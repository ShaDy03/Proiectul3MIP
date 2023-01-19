using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Produs
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the name of the product")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price is required!")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Please enter your desired quantity")]
        public double Quantity { get; set; } 

        public int ImageID { get; set; }

        public int BrandID { get; set; }

        [Required(ErrorMessage = "UnitID is required!")]
        public int UnitID { get; set; }

        [ForeignKey("ImagesID")]
        public Image Images { get; set; }
        
        [ForeignKey("BrandID")]
        public Brand Brand { get; set; }

        [ForeignKey("UnitID")]
        public Unit Unit { get; set; }

    }
}
