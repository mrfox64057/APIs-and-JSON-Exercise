using Newtonsoft.Json.Linq;
using System.Net.Http;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("The great Ron West once said"+"\n");
            //QuoteGenerator.YeQuote();
            //QuoteGenerator.RonWords();
            OpenWeatherMapAPI.GetWeather();
        }
    }
}
