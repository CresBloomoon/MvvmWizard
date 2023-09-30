using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WizardDemo.Converters {
    public class VisibilityToBooleanConverter : IValueConverter {
        public static readonly VisibilityToBooleanConverter Instance = new VisibilityToBooleanConverter();

        private VisibilityToBooleanConverter() {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            return value.Equals(true) ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}
