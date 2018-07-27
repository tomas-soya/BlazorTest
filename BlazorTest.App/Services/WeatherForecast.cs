using System;
using System.Diagnostics;

namespace BlazorTest.App.Services
{
    public class WeatherForecast
    {
        [Name("日期")]
        public DateTime Date { get; set; }
        [Name("摄氏度")]
        public int TemperatureC { get; set; }
        [Name("华氏度")]
        public int TemperatureF { get; set; }
        [Name("描述")]
        public string Summary { get; set; }
    }
}
