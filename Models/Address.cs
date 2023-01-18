using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        public string Street { get; set; }

        public int Number { get; set; }

        public int Apartament { get; set; }

        public int PostalCode { get; set; }

        public string Telephone { get; set; }

        public int CityID { get; set; }

        public int CountryID { get; set; }

        [ForeignKey("CityID")]
        public City City { get; set; }

        [ForeignKey("CountryID")]
        public Country Country { get; set; }
    }
}
