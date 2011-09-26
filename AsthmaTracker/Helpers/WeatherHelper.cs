using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Xml.Linq;
using AsthmaTracker.Messages;
using AsthmaTracker.Model;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Threading;
using Microsoft.Phone.Net.NetworkInformation;

namespace AsthmaTracker.Helpers
{
    public class WeatherHelper
    {
        private static void LoadWeather(double latitude, double longitude)
        {
            //check if network and client are available and newsurl exists
            if (!NetworkInterface.GetIsNetworkAvailable())
                return;
            string url = string.Format("http://forecast.weather.gov/MapClick.php?lat={0}&lon={1}&FcstType=dwml", latitude, longitude);

            var request = HttpWebRequest.Create(url);

            request.BeginGetResponse((iar) =>
            {
                string contents = "";
                var response = request.EndGetResponse(iar);
                using (var stream = response.GetResponseStream())
                {
                    using (var reader = new StreamReader(stream))
                    {
                        contents = reader.ReadToEnd();
                    }
                }

                XDocument weatherDoc = XDocument.Parse(contents);

                XElement data = weatherDoc.Root.Element("data");

                // create placeholder for the new weather model
                var forecast = new Forecast()
                {
                    // PeriodName: time-layout/start-valid-time[0]/@period-name/value
                    PeriodName = data.Element("time-layout")
                                     .Element("start-valid-time")
                                     .Attribute("period-name")
                                     .Value,

                    // ForecastDate: time-layout/start-valid-time[0]/value
                    ForecastDate = DateTime.Parse(
                                        data.Element("time-layout")
                                            .Element("start-valid-time")
                                            .Value),

                    // HighTemperature: parameters/temperature[type='maximum']/value[0]/value
                    HighTemperature = Double.Parse(
                                            data.Element("parameters")
                                                .Elements("temperature")
                                                .First(e => e.Attribute("type").Value == "maximum")
                                                .Element("Value")
                                                .Value),

                    // LowTemperature: parameters/temperature[type='minimum']/value[0]/value
                    LowTemperature = Double.Parse(
                                            data.Element("parameters")
                                                .Elements("temperature")
                                                .First(e => e.Attribute("type").Value == "minimum")
                                                .Element("Value")
                                                .Value),

                    // Conditions: weather/weather-conditions/@weather-summary/value
                    Conditions = data.Element("weather")
                                     .Element("weather-conditions")
                                     .Attribute("weather-summary")
                                     .Value,

                    // ImageUrl: conditions-icon/icon-link[0]/value
                    ImageUrl = data.Element("conditions-icon")
                                   .Element("icon-link")
                                   .Value,
                };

                // send message that data has been received
                Messenger.Default.Send<WeatherDataRetrievedMessage>(
                    new WeatherDataRetrievedMessage()
                    {
                        WeatherData = forecast
                    });
            }, null);
        }

        private void LoadWeatherCompleted(string results)
        {
        }
    }
}