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

    private void ActionButton_OnClicked(object? sender, EventArgs e)
    {
        Application.Current!.Windows[0].Page!.Navigation.PushModalAsync(new NavigationPage(new CameraPage()));
    }
}