using System;
using System.Diagnostics;

namespace BlazorTest.App.Services
{
    public class WeatherForecast
    {
        [Name("����")]
        public DateTime Date { get; set; }
        [Name("���϶�")]
        public int TemperatureC { get; set; }
        [Name("���϶�")]
        public int TemperatureF { get; set; }
        [Name("����")]
        public string Summary { get; set; }
    }
}
