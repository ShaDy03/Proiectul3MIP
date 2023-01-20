namespace Models
{
    public class RegisterDatas
    {
        public RegisterDatas(List<Country> countryList, List<City> cityList)
        {
            CountryList = countryList;
            CityList = cityList;
        }

        public List<Country> CountryList { get; private set; }
        public List<City> CityList { get; private set; }
    }
}
