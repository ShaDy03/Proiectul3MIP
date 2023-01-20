using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your street")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Please enter your number")]
        public int Number { get; set; }

        public int Apartament { get; set; }
        
        [Required(ErrorMessage = "Please enter your postal code")]
        public int PostalCode { get; set; }

        [Required(ErrorMessage = "Telephone is required!")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "CityID is required!")]
        public int CityID { get; set; }

        [Required(ErrorMessage = "CountryID is required!")]
        public int CountryID { get; set; }

        [ForeignKey("CityID")]
        public City City { get; set; }

        [ForeignKey("CountryID")]
        public Country Country { get; set; }
    }
}
