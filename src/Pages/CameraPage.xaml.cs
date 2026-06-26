namespace instagrim.Pages;

public partial class CameraPage : ContentPage
{
    public CameraPage()
    {
        InitializeComponent();
    }

    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        var cameraPermissions = await Permissions.RequestAsync<Permissions.Camera>();

        if (cameraPermissions == PermissionStatus.Granted)
        {
            Camera.IsEnabled = true;
        }
        else
        {
            await DisplayAlertAsync("Camera Permission", "You need to allow Instagrim to access your camera. Please update your phone's settings.", "OK");
        }
    }

    private async void CloseButton_OnClicked(object? sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}