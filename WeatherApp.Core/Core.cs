using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Core
{
    class Core
    {
        public static async Task<Weather> GetWeather (string zipCode)
        {
            string key = "d8c2096e746ece1f868777d30d879493";
            string queryString = "d8c2096e746ece1f868777d30d879493";

            dynamic results = await DataService.GetDataFromService(queryString).ConfigureAwait(false);
            var weather = new Weather();
            weather.Temperature = (string)results["main"]["temp"] + " C";
            return weather;

        }
    }
}
