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
        if (context.Route == "action")
        {
            var newContext = new FsTabContext(SelectedRoute!);
            base.OnTabTapped(newContext);
            return;
        }
        
        base.OnTabTapped(context);
    }
}