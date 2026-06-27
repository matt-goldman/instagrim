using FlagstoneUI.Core.Controls;
using instagrim.Pages;

namespace instagrim.Controls;

public partial class NavBar : FsTabBarBase
{
    public NavBar()
    {
        InitializeComponent();
        InitializeTabContainer();
    }

    protected override Layout TabContainer => Tabs;

    protected override void OnTabTapped(FsTabContext context)
    {
        if (context.Title == "Action")
        {
            return;
        }
        
        base.OnTabTapped(context);
    }

    private async void ActionButton_OnClicked(object? sender, EventArgs e)
    {
        var page = Application.Current!.Windows[0].Page!;
        if (DeviceInfo.Current.Platform == DevicePlatform.iOS && DeviceInfo.Current.DeviceType == DeviceType.Virtual)
        {
            await page.DisplayAlertAsync("Camera not available", "Camera is not available on simulator", "OK");
        }
        else
        {
            await page.Navigation.PushModalAsync(new NavigationPage(new CameraPage()));
        }
    }
}