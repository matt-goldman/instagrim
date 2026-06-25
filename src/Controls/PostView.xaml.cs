namespace instagrim.Controls;

public partial class PostView : ContentView
{
    public PostView()
    {
        InitializeComponent();
    }

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
        LayoutGrid.RowDefinitions = new RowDefinitionCollection()
        {
            new RowDefinition(30),
            new RowDefinition(width),
            new RowDefinition(30),
            new RowDefinition(10),
            new RowDefinition(GridLength.Auto),
            new RowDefinition(10),
            new RowDefinition(10),
        };
    }
}