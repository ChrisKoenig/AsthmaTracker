using System;
using AsthmaTracker.Model;
using GalaSoft.MvvmLight;

namespace AsthmaTracker.Models
{
    public class Reading : ObservableObject
    {
        // Fields...
        private int _ReadingValue;
        private DateTime _ReadingDate;
        private AirQuality _AirQualityData;
        private Forecast _ForecastData;

        public DateTime ReadingDate
        {
            get { return _ReadingDate; }
            set
            {
                if (_ReadingDate == value)
                    return;
                _ReadingDate = value;
                RaisePropertyChanged(() => this.ReadingDate);
            }
        }

        public int ReadingValue
        {
            get { return _ReadingValue; }
            set
            {
                if (_ReadingValue == value)
                    return;
                _ReadingValue = value;
                RaisePropertyChanged(() => this.ReadingValue);
            }
        }

        public Forecast ForecastData
        {
            get { return _ForecastData; }
            set
            {
                if (_ForecastData == value)
                    return;
                _ForecastData = value;
                RaisePropertyChanged(() => this.ForecastData);
            }
        }

        public AirQuality AirQualityData
        {
            get { return _AirQualityData; }
            set
            {
                if (_AirQualityData == value)
                    return;
                _AirQualityData = value;
                RaisePropertyChanged(() => this.AirQualityData);
            }
        }
    }
}