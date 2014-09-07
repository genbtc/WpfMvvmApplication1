using System;
using System.Globalization;
using System.Windows.Data;

namespace WpfMvvmApplication1.Converters
{
    [ValueConversion(typeof(DateTime), typeof(String))]
    public class DateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return 0;
            DateTime now = DateTime.Today;
            int age = now.Year - ((DateTime)value).Year;
            if (now < ((DateTime)value).AddYears(age)) 
                age--;

            return age.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
