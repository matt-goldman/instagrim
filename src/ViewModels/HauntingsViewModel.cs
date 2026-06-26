using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using instagrim.Models;
using instagrim.Services;
using Plugin.Maui.SmartNavigation.Behaviours;

namespace instagrim.ViewModels;

public partial class HauntingsViewModel(ImageService service) : ObservableObject, IViewModelLifecycle
{
    public ObservableCollection<SocialUpdate> Updates { get; private set; } = [];
    
    [ObservableProperty]
    public partial bool IsBusy { get; set; }
    
    public async Task OnInitAsync(bool isFirstNavigation)
    {
        IsBusy = true;
        
        var updates = await service.GetUpdates();

        updates.Shuffle();
        
        Updates.Clear();

        foreach (var update in updates.Take(6))
        {
            Updates.Add(update);
        }
        
        IsBusy = false;
    }
}