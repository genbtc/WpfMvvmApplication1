﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace WpfMvvmApplication1.Converters
{
    public class BooltoString : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return (bool)value == false ? "-" : "+";
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return (string)value != "-";
        }
    }
}