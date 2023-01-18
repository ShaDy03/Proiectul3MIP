using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sector { get; set; }


    }
}
