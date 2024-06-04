using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++) 
            {
                Quotes.KayneQuote();

                Quotes.RonQuote();
            }
            {
                OpenWeatherMapAPI.CurrentWeather();
            }
            
        }
    }
}
