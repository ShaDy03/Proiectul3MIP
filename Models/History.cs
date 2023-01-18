using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class History
    {
        [Key]
        public int Id { get; set; }
        public int ProdusID { get; set; }
        public int UserID { get; set; }
        [ForeignKey("ProdusID")]
        public Produs Produs { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }




       
    }
}
