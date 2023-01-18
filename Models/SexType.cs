using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class SexType
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }

    }

}
