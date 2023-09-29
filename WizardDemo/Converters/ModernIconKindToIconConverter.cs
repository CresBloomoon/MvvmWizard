using MahApps.Metro.IconPacks;
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
    public class ModernIconKindToIconConverter : IValueConverter
    {
        public static readonly ModernIconKindToIconConverter Instance = new ModernIconKindToIconConverter();

        private readonly ThicknessConverter thicknessConverter;

        private ModernIconKindToIconConverter()
        {
            this.thicknessConverter = new ThicknessConverter();
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return null;
            }

            var margin = (Thickness)this.thicknessConverter.ConvertFrom(parameter);

            var kind = (PackIconModernKind)value;

            return new PackIconModern
            {
                Kind = kind,
                Margin = margin,
            };
        }
    }

}
