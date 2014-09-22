using System.Windows.Data;
using WpfMvvmApplication1.Models;

namespace WpfMvvmApplication1.Converters
{
    class CivilityConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var c = new Civilities();
            return value !=null ? c.ListCivilities[(int)value].Value : null;
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }
}
