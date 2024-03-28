using System.Text.Json;
using System.Text.Json.Serialization;
using WeatherServiceApp.DTO;

namespace WeatherServiceApp.Services
{
    public class LocationService
    {
        public IEnumerable<CityAndZone> Zones { get; set; }
        public IEnumerable<Region> Regions { get; set; }
        public IEnumerable<State> States { get; set; }

        public LocationService()
        {
            //Normally I would add null checks but since the data is from static files I just suppressed the warnings.
            Zones = JsonSerializer.Deserialize<IEnumerable<CityAndZone>>(File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "cities_and_zones.json")))!;
            Regions = JsonSerializer.Deserialize<IEnumerable<Region>>(File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "regions.json")))!;
            States = JsonSerializer.Deserialize<IEnumerable<State>>(File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "states.json")))!;
        }

        
    }
}
