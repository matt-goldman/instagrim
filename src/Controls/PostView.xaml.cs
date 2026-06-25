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
            new RowDefinition(50),
            new RowDefinition(width),
            new RowDefinition(40),
            new RowDefinition(20),
            new RowDefinition(40),
            new RowDefinition(20),
            new RowDefinition(40),
        };
    }
}