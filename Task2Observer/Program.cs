using System;
using Task2Observer.Observers;
using Task2Observer.Subjects;

namespace Task2Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4d);
            weatherData.SetMeasurements(82, 70, 29.2d);
            weatherData.SetMeasurements(78, 90, 29.2d);
        }
    }
}

