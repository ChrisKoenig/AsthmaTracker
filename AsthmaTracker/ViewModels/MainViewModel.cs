using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Xml.Linq;
using AsthmaTracker.Model;
using GalaSoft.MvvmLight;

namespace AsthmaTracker.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            if (IsInDesignMode)
            {
            }
            else
            {
            }
        }

        #region EntryDate

        private DateTime _entryDate = DateTime.Now;

        public DateTime EntryDate
        {
            get
            {
                return _entryDate;
            }

            set
            {
                if (_entryDate == value)
                {
                    return;
                }
                _entryDate = value;
                RaisePropertyChanged(() => this.EntryDate);
            }
        }

        #endregion EntryDate

        #region WeatherData

        private Forecast _weatherData = null;

        public Forecast WeatherData
        {
            get
            {
                return _weatherData;
            }

            set
            {
                if (_weatherData == value)
                {
                    return;
                }
                _weatherData = value;
                RaisePropertyChanged(() => this.WeatherData);
            }
        }

        #endregion WeatherData
    }
}