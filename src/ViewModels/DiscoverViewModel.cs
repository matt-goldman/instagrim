using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using instagrim.Models;
using instagrim.Services;
using Plugin.Maui.SmartNavigation.Behaviours;

namespace instagrim.ViewModels;

public partial class DiscoverViewModel (ImageService service) : ObservableObject, IViewModelLifecycle
{
    public ObservableCollection<Post> Posts { get; set; } = [];
    
    [ObservableProperty]
    public partial bool IsBusy { get; set; }
    
    public async Task OnInitAsync(bool isFirstNavigation)
    {
        IsBusy = true;

        var results = await service.GetDiscovery();
        
        Posts.Clear();
        
        foreach (var post in results)
        {
            Posts.Add(post);
        }
        
        IsBusy = false;
    }
}