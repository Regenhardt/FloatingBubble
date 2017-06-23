using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace FloatingBubble.Converters
{
	[ValueConversion(typeof(bool), typeof(Visibility))]
	public class NegatedVisibilityConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is bool)
			{
				return (bool)value ? Visibility.Collapsed : Visibility.Visible;
			}
			else
			{
				return Binding.DoNothing;
			}
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is Visibility)
			{
				return (Visibility)value == Visibility.Visible ? false : true;
			}
			else return Binding.DoNothing;
		}
	}
}
