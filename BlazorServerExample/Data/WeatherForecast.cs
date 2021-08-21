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

    public class TemperatureScale
    {
        public Guid TemperatureScaleId { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public bool IsDefault { get; set; }
    }

    public class TemperatureScaleConversion
    {
        public Guid TemperatureScaleConversionId { get; set; }
        public TemperatureScale FromScale { get; set; }
        public TemperatureScale ToScale { get; set; }
        public string Formula { get; set; }

        public decimal Convert(decimal value)
        {

            return 0m;
        }
    }
}
