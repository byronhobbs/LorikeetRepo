﻿using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lorikeet.Models
{
    /// <summary>
    /// This class get and store data from OpenWeatherMap
    /// </summary>
    public class WeatherAndForecast
    {
        /// <summary>
        /// Api key for OpenWeatherMap
        /// </summary>
        private const string ApiKey = "d459e076696773f16a81f2f292395e26";

        public WeatherModel Weather { get; private set; }
        public ForecastModel Forecast { get; private set; }

        /// <summary>
        /// Store response from OpenWeatherMap
        /// </summary>
        /// <param name="cityName">City name</param>
        /// <returns>Status</returns>
        public async Task<bool> GetData(string cityName)
        {
            // Send request
            var responseWeather = await _getResponse(cityName);
            var responseForecast = await _getResponse(cityName, "forecast");

            // Check for success status code
            if (!responseWeather.IsSuccessStatusCode || !responseForecast.IsSuccessStatusCode)
                return false;

            // Save data for weather
            var responseWeatherResult = await responseWeather.Content.ReadAsStringAsync();
            Weather = WeatherModel.FromJson(responseWeatherResult);

            // Save data for forecast
            var responseForecastResult = await responseForecast.Content.ReadAsStringAsync();
            Forecast = ForecastModel.FromJson(responseForecastResult);

            return true;
        }

        /// <summary>
        /// Send request to OpenWeatherMap
        /// </summary>
        /// <param name="cityName">City name</param>
        /// <param name="type">Request type (find or forecast)</param>
        /// <returns>OpenWeatherMap response</returns>
        private async Task<HttpResponseMessage> _getResponse(string cityName, string type = "find")
        {
            // Check for valid type
            if (!((type == "find") || (type == "forecast")))
                return new HttpResponseMessage(HttpStatusCode.NotFound);

            // Create uri for request
            using (var client = new HttpClient())
            {
                var uri = new Uri($"http://api.openweathermap.org/data/2.5/{type}?q={cityName}&units=metric&appid={ApiKey}");
                return await client.GetAsync(uri);
            }
        }
    }
}