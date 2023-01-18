using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Adress
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public string Street { get; set; }
        public int PostalCode { get; set; }
        public int CityID { get; set; }
        [ForeignKey("CityID")]
        public City City { get; set; }
        public int CountryID { get; set; }
        [ForeignKey("CountryID")]
        public Country Country { get; set; }


    }
}
