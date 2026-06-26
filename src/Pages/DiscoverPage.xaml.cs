using instagrim.ViewModels;

namespace instagrim.Pages;

public partial class DiscoverPage : ContentPage
{
    private double _imageSize;

    public double ImageSize
    {
        get => _imageSize;
        set
        {
            _imageSize = value;
            OnPropertyChanged(nameof(ImageSize));
        }
    }
    
    public DiscoverPage(DiscoverViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
        ImageSize = (width / 3) - 3;
    }
}