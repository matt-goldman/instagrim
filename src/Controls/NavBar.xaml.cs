using FlagstoneUI.Core.Controls;

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
}