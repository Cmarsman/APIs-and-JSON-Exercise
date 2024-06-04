using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    public class  Quotes
    {
        public static void KayneQuote() 
        {
            var client = new HttpClient();

            var kayneURL = "https://api.kanye.rest";

            var kayneResponse = client.GetStringAsync(kayneURL).Result;

            var kayneQuote = JObject.Parse(kayneResponse).GetValue("quote").ToString();

            Console.WriteLine($"Kayne: '{ kayneQuote}'");
            Console.WriteLine();
        }
        public static void RonQuote() 
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            
            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"Ron: '{ronQuote}'");
            Console.WriteLine();
        }
    }
}
