using System;
using System.Windows.Data;

namespace AsthmaTracker.Converters
{
    public class WholeNumberConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double val;
            if (Double.TryParse(value.ToString(), out val))
            {
                return Math.Round(val);
            }
            else
            {
                return 0;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}