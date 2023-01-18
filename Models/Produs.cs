using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Produs
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public double Quantity { get; set; } 

        public int ImageID { get; set; }

        public int BrandID { get; set; }

        public int UnitID { get; set; }

        [ForeignKey("ImagesID")]
        public Image Images { get; set; }
        
        [ForeignKey("BrandID")]
        public Brand Brand { get; set; }

        [ForeignKey("UnitID")]
        public Unit Unit { get; set; }

    }
}
