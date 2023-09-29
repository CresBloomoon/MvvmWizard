using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;

namespace WizardDemo.Converters
{
    public class SliderValueToVerticalAlignmentConverter : IValueConverter
    {
        public static readonly SliderValueToVerticalAlignmentConverter Instance =
            new SliderValueToVerticalAlignmentConverter();

        private SliderValueToVerticalAlignmentConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.Equals(0.0))
            {
                return VerticalAlignment.Top;
            }

            if (value.Equals(50.0))
            {
                return VerticalAlignment.Center;
            }

            if (value.Equals(100.0))
            {
                return VerticalAlignment.Bottom;
            }

            return DependencyProperty.UnsetValue;
        }
    }

}
