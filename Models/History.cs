using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class History
    {
        [Key]
        public int Id { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public double Total { get; set; }

        public string OrderNumber { get; set; }

        public int ProdusID { get; set; }

        public int UserID { get; set; }

        [ForeignKey("ProdusID")]
        public Produs Produs { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }
    }
}
