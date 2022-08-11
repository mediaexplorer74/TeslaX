using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace TeslaX.Converters
{
    class StatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (ViewModels.MainViewModel.StatusEnum)value;
            
            switch (status)
            {
                case ViewModels.MainViewModel.StatusEnum.IdleGrid:
                    return Color.Lime;
                case ViewModels.MainViewModel.StatusEnum.ExportingToGrid:
                    return Color.Magenta;
                case ViewModels.MainViewModel.StatusEnum.ImportingFromGrid:
                    return Color.DodgerBlue;
                case ViewModels.MainViewModel.StatusEnum.Error:
                default:
                    return Color.Red;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
