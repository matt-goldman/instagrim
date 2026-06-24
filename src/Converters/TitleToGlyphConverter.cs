using System.Globalization;
using Plugin.Maui.Lucide;

namespace instagrim.Converters;

public class TitleToGlyphConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is string title)
        {
            return title switch
            {
                "Feed" => Icons.House,
                "Discover" => Icons.Compass,
                "Hauntings" => Icons.Skull,
                "Profile" => Icons.User,
                "Action" => Icons.House,
                _ => string.Empty
            };
        }
        
        return string.Empty;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}