using System;
using System.Globalization;
using System.Windows.Data;

namespace WpfMvvmApplication1.Converters
{
    [ValueConversion(typeof(int), typeof(int))]
    public class AddOne : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((int)value == 0)
                return 0;
            return (int)value - 1;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)value + 1;
        }
    }
}
