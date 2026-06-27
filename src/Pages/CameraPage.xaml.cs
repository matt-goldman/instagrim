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
        
        if (DeviceInfo.Current.Platform == DevicePlatform.iOS && DeviceInfo.Current.DeviceType == DeviceType.Virtual)
        {
            // camera not supported on ios simulator
            await DisplayAlertAsync("Camera Error", "Please ensure you have granted permission to the camera. Note it doesn't work on iOS simulator.", "OK");
            await Navigation.PopModalAsync();
        }
        else
        {
            var cameraPermissions = await Permissions.RequestAsync<Permissions.Camera>();

            if (cameraPermissions == PermissionStatus.Granted && MediaPicker.Default.IsCaptureSupported)
            {
                Camera.IsVisible = true;
                Camera.IsEnabled = true;
            }
            else
            {
                await DisplayAlertAsync("Camera Permission",
                    "You need to allow Instagrim to access your camera. Please update your phone's settings.", "OK");
                await Navigation.PopModalAsync();
            }
        }
    }

    private async void CloseButton_OnClicked(object? sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}