using FlagstoneUI.Core.Builders;
using Microsoft.Extensions.Logging;
using Plugin.Maui.Lucide;
using Plugin.Maui.SmartNavigation.Attributes;

namespace instagrim;

[UseAutoDependencies]
public static partial class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("Creepster-Regular.ttf", "Creepster");
			})
			.UseCommunityToolkit()
			.UseLucide()
			.UseFlagstoneUI()
			.UseAutodependencies();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
