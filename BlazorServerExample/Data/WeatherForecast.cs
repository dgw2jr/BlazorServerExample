using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorServerExample.Data
{
    public class WeatherForecast
    {
        public WeatherForecast()
        {
            WeatherForecastId = Guid.NewGuid();
        }

        public Guid WeatherForecastId { get; set; }

        public DateTime Date { get; set; }

        public int TemperatureC => (TemperatureF - 32) * 5 / 9;

        [Required]
        public int TemperatureF { get; set; }

        [Required, StringLength(255)]
        public string Summary { get; set; }
    }
}
