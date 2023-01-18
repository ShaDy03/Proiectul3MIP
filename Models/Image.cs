using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        public string Source { get; set; }
        public int SourceID { get; set; }
        [ForeignKey("SourceID")]
        public Produs Produs { get; set; }



    }
}
