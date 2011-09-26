using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using GalaSoft.MvvmLight;

namespace AsthmaTracker.ViewModels
{
    public class AboutViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the AboutViewModel class.
        /// </summary>
        public AboutViewModel()
        {
        }

        // Fields...
        private string _DatabaseVersionNumber;

        public string DatabaseVersionNumber
        {
            get { return _DatabaseVersionNumber; }
            set
            {
                if (_DatabaseVersionNumber == value)
                    return;
                _DatabaseVersionNumber = value;
                this.RaisePropertyChanged(() => this.DatabaseVersionNumber);
            }
        }
    }
}