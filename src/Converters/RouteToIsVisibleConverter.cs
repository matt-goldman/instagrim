using System.Globalization;

namespace instagrim.Converters;

public class RouteToIsVisibleConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is not string route)
        {
            throw new NotImplementedException();
        }

        return true;//route != "action";
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}