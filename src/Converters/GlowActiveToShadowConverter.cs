using System.Globalization;

namespace instagrim.Converters;

public class GlowActiveToShadowConverter : IValueConverter
{
    public required Brush ShadowBrush { get; set; } 
    
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is not bool glowActive)
        {
            return new Shadow();
        }
        
        return new Shadow
        {
            Offset  = new Point(0, 0),
            Opacity = 0.9f,
            Brush   = ShadowBrush,
            Radius  = glowActive? 7 : 0
        };
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}