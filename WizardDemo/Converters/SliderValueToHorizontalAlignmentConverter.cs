using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WizardDemo.Converters {
    public class SliderValueToHorizontalAlignmentConverter : IValueConverter {
        public static readonly SliderValueToHorizontalAlignmentConverter Instance =
            new SliderValueToHorizontalAlignmentConverter();

        private SliderValueToHorizontalAlignmentConverter() {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value.Equals(0.0)) {
                return HorizontalAlignment.Left;
            }

            if (value.Equals(50.0)) {
                return HorizontalAlignment.Center;
            }

            if (value.Equals(100.0)) {
                return HorizontalAlignment.Right;
            }

            return DependencyProperty.UnsetValue;
        }
    }
}