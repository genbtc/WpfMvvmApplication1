using System.Windows.Data;
using WpfMvvmApplication1.Models;

namespace WpfMvvmApplication1.Converters
{
    class CivilityConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var c = new Civilities();
            if (value != null)
                return c.ListCivilities[(int)value].Value;
            else
                return null;
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }
}
