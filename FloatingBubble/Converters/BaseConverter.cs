using System;
using System.Globalization;
using System.Windows.Data;

namespace FloatingBubble.Converters
{
    /// <summary>
    /// Base class for converters
    /// </summary>
    abstract class BaseConverter : IValueConverter
    {
        abstract public object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        abstract public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
    }
}
