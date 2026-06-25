using instagrim.ViewModels;

namespace instagrim.Pages;

public partial class FeedPage : ContentPage
{
    public FeedPage(FeedViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}