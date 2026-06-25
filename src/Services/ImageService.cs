using System.Collections.ObjectModel;
using System.Net.Http.Json;
using instagrim.Models;

namespace instagrim.Services;

public class ImageService
{
    private HttpClient? _httpClient;
    
    private readonly SemaphoreSlim _httpClientQueue =  new SemaphoreSlim(1, 1);

    private const string SearchQuery = "search/photos?query=halloween";

    private IReadOnlyList<string> Locations =>
    [
        "Sleepy Hollow",
        "Salem",
        "Transylvania",
        "Widows Peak",
        "Arkham Asylum",
        "Amityville",
        "Elm Street",
        "Silent Hill",
        "Hawkins, Indiana",
        "Sunnydale"
    ];

    private async Task<HttpClient> GetClient()
    {
        await _httpClientQueue.WaitAsync();
        
        if (_httpClient is not null)
        {
            return _httpClient;
        }

        await using var stream = await FileSystem.OpenAppPackageFileAsync("ApiKey.txt");
        using var reader = new StreamReader(stream);

        var apiKey = await reader.ReadToEndAsync();
        

        _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://api.unsplash.com/")
        };
        
        _httpClient.DefaultRequestHeaders.Add("Client-ID", apiKey);
        
        _httpClientQueue.Release();
        return _httpClient;
    }

    public async Task<List<Post>> GetFeed()
    {
        var client = await GetClient();
        var unsplashResponse = await client.GetFromJsonAsync<UnsplashResponse>(SearchQuery);

        if (!(unsplashResponse?.Results?.Length > 0))
        {
            return [];
        }

        var posts = new List<Post>();

        foreach (var result in unsplashResponse.Results)
        {
            var locationIndex = Random.Shared.Next(Locations.Count);
            var location = Locations[locationIndex];
            posts.Add(new Post
            {
                ImageUrl    = result.Urls!.Regular!,
                Location    = location,
                Username    = result.User.InstagramUsername??result.User.Username,
                Description = result.Description!,
                Likes       = result.Likes,
                IsFavourite = Random.Shared.Next() % 2 == 0,
                Comments    = result.User.TotalPhotos,
                IsLiked     = Random.Shared.Next() % 2 == 0,
            });
        }
        
        return posts;
    }
}