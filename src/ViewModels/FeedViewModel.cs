using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using instagrim.Models;
using instagrim.Services;
using Plugin.Maui.SmartNavigation.Behaviours;

namespace instagrim.ViewModels;

public partial class FeedViewModel (ImageService service) : ObservableObject, IViewModelLifecycle
{
    public ObservableCollection<Post> Feed { get; set; } = [];
    
    [ObservableProperty]
    public partial bool IsBusy { get; set; }
    
    public async Task OnInitAsync(bool isFirstNavigation)
    {
        IsBusy = true;
        var results = await service.GetFeed();
        Feed.Clear();
        results.ForEach(r => Feed.Add(r));
        IsBusy = false;
    }
}