using System;

namespace AsthmaTracker.Services
{
    public class MockWeatherService : IWeatherService
    {
        public void LoadWeather(double latitude, double longitude)
        {
            throw new NotImplementedException();
        }
    }
}