using System.Globalization;
using Plugin.Maui.Lucide;

namespace instagrim.Converters;

public class RouteToGlyphConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is string route)
        {
            return route switch
            {
                "feed" => Icons.House,
                "discover" => Icons.Compass,
                "hauntings" => Icons.Skull,
                "profile" => Icons.User,
                "action" => Icons.House,
                _ => throw new  ArgumentOutOfRangeException(nameof(value), route, null)
            };
        }
        
        throw new NotImplementedException();
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}