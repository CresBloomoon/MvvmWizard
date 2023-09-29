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
    public class ThicknessToDoubleConverter : IValueConverter
    {
        public static readonly ThicknessToDoubleConverter Instance = new ThicknessToDoubleConverter();

        private ThicknessToDoubleConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return DependencyProperty.UnsetValue;
            }

            return new Thickness((double)value);
        }
    }
}
