namespace WeatherServiceApp.DTO
{

    public class State
    {
        public required string Name { get; set; }
        public required string Abbreviation { get; set; }
        public int RegionId { get; set; }
    }

}
