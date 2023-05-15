using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        public static void GetWeather()
        {
            var client = new HttpClient();           
            var cityName = "Benton";
            var weatherUrl = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={ApiKey.Key}&units=imperial";
            var weatherRepsonse = client.GetStringAsync(weatherUrl).Result;
            var weatherObj = JObject.Parse(weatherRepsonse);
            Console.WriteLine(weatherObj["main"]["temp"]);
        }
    }
}
