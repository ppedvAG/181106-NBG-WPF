using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace BindingDemo
{
    class Farbconverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string farbe = (string)value;
            if (farbe == "Rot")
                return new SolidColorBrush(Colors.Red);
            //....
            else
            {
                var properties = typeof(Colors).GetProperties();

                var color = properties.FirstOrDefault(x => x.Name.ToLower() == farbe.ToLower());
                return color != null ? new SolidColorBrush((Color)color.GetValue(typeof(Colors))) : null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
