using instagrim.ViewModels;

namespace instagrim.Pages;

public partial class HauntingsPage : ContentPage
{
    public HauntingsPage(HauntingsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}