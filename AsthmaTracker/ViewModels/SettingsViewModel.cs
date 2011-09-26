using System;
using System.Device.Location;
using GalaSoft.MvvmLight;

namespace AsthmaTracker.ViewModel
{
    public class SettingsViewModel : ViewModelBase
    {
        public SettingsViewModel()
        {
            // for testing  http://forecast.weather.gov/MapClick.php?lat=33.18993&lon=-96.880832&FcstType=dwml
            CurrentPosition = new GeoCoordinate(33.18993, -96.880832);

            if (IsInDesignMode)
            {
            }
            else
            {
            }
        }

        private GeoCoordinate _currentPostition = null;

        public GeoCoordinate CurrentPosition
        {
            get
            {
                return _currentPostition;
            }

            set
            {
                if (_currentPostition == value)
                {
                    return;
                }
                _currentPostition = value;
                RaisePropertyChanged(() => this.CurrentPosition);
            }
        }
    }
}