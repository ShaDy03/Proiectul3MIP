using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class History
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "You have nothing in the buyer's section")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "You have nothing in the buyer's section")]
        public double Price { get; set; }

        [Required(ErrorMessage = "You have nothing in the buyer's section")]
        public double Total { get; set; }

        [Required(ErrorMessage = "You have nothing in the buyer's section")]
        public string OrderNumber { get; set; }

        public int ProdusID { get; set; }

        public int UserID { get; set; }

        [ForeignKey("ProdusID")]
        public Produs Produs { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }
    }
}
