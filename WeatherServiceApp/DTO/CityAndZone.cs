namespace WeatherServiceApp.DTO
{

    public class CityAndZone
    {
        public required string City { get; set; }
        public required string State { get; set; }
        public required string StateAbbreviation { get; set; }
        public required string FIPS { get; set; }
        public required string County { get; set; }
        public required string Zone { get; set; }
        public required string ZoneName { get; set; }
    }

}
