using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using WpfMvvmApplication1.Models;

namespace WpfMvvmApplication1.Converters
{
    public class EFtoIEnum : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            if (value == null)
                return new List<FAMILIES> { new FAMILIES() };
            Type classtype = value.GetType();
            if (classtype == typeof (FAMILIES))
            {
                return new List<FAMILIES> {(FAMILIES)value};
            }
            else if (classtype == typeof (CHILDREN))
            {
                return new List<CHILDREN> {(CHILDREN)value};
            }
            return new List<FAMILIES> {new FAMILIES()};
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;
            Type classtype = value.GetType();
            if (classtype == typeof (FAMILIES))
            {
                var e = value as IEnumerable<FAMILIES>;
                return e != null ? e.First() : null;
            }
            else if (classtype == typeof(CHILDREN))
            {
                var e = value as IEnumerable<CHILDREN>;
                return e != null ? e.First() : null;
            }
            return new FAMILIES() ;
        }
    }
}