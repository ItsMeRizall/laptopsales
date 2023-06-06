using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

public class WeatherAPI
{
    private string apiKey = "7560059e26ca32a9f36700ca2538a023";

    public async Task<WeatherData> GetWeather(string city)
    {
        using (HttpClient client = new HttpClient())
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}";

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(json);
                return weatherData;
            }
            else
            {
                throw new Exception("Failed to retrieve weather data.");
            }
        }

    }
}



public class WeatherData
{
    public main Main { get; set; }
    public List<weather> Weather { get; set; }
    public string name { get; set; }
}


public class weather
{
    public string main { get; set; }
    public string description { get; set; }
    public string icon { get; set; }
}

public class main
{
    public double temp { get; set; }
    public double temp_min { get; set; }
    public double temp_max { get; set;}
}