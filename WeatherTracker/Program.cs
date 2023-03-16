// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json.Linq;

namespace WeatherTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
          
            var city = "Oklahoma City";

            var apiKey = "87ea734b11c7be6b0ce70dde4b08cc32";

            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=imperial&appid={apiKey}";

            var response = client.GetStringAsync(weatherURL).Result;
           
            var formattedResponse = JObject.Parse(response).GetValue("main");
            
            Console.WriteLine(formattedResponse);
        }
    }
}