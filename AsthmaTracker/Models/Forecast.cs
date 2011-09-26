using System;
using System.Collections.Generic;
using System.Linq;
using GalaSoft.MvvmLight;

namespace AsthmaTracker.Model
{
    public class Forecast : ObservableObject
    {
        // Fields...
        private string _PeriodName;
        private string _ImageUrl;
        private double _HighTemperature;
        private double _LowTemperature;
        private string _Conditions;
        private DateTime _ForecastDate;

        #region ForecastDate

        public DateTime ForecastDate
        {
            get { return _ForecastDate; }
            set
            {
                if (_ForecastDate == value)
                    return;
                _ForecastDate = value;
                RaisePropertyChanged(() => ForecastDate);
            }
        }

        #endregion ForecastDate

        #region Conditions

        public string Conditions
        {
            get { return _Conditions; }
            set
            {
                if (_Conditions == value)
                    return;
                _Conditions = value;
                RaisePropertyChanged(() => Conditions);
            }
        }

        #endregion Conditions

        #region HighTemperature

        public double HighTemperature
        {
            get { return _HighTemperature; }
            set
            {
                if (_HighTemperature == value)
                    return;
                _HighTemperature = value;
                RaisePropertyChanged(() => this.HighTemperature);
            }
        }

        #endregion HighTemperature

        #region LowTemperature

        public double LowTemperature
        {
            get { return _LowTemperature; }
            set
            {
                if (_LowTemperature == value)
                    return;
                _LowTemperature = value;
                RaisePropertyChanged(() => this.LowTemperature);
            }
        }

        #endregion LowTemperature

        #region ImageUrl

        public string ImageUrl
        {
            get { return _ImageUrl; }
            set
            {
                if (_ImageUrl == value)
                    return;
                _ImageUrl = value;
                RaisePropertyChanged(() => this.ImageUrl);
            }
        }

        #endregion ImageUrl

        #region PeriodName

        public string PeriodName
        {
            get { return _PeriodName; }
            set
            {
                if (_PeriodName == value)
                {
                    return;
                }
                _PeriodName = value;
                RaisePropertyChanged(() => this.PeriodName);
            }
        }

        #endregion PeriodName
    }
}