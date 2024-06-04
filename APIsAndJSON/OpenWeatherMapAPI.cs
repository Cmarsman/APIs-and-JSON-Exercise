using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        public static void CurrentWeather() 
        {
            var client = new HttpClient();

            var appSettingsText = File.ReadAllText("appsettings.json");

            var APIKey = JObject.Parse(appSettingsText)["nameAPIKey"].ToString();

            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?zip=76177&appid={APIKey}&units=imperial";

            var weatherResponse = client.GetStringAsync(weatherURL).Result;

            var currentTemp = JObject.Parse(weatherResponse)["main"]["temp"].ToString();

            Console.WriteLine($"Current Weather: '{currentTemp}'");
        }
    }
}
