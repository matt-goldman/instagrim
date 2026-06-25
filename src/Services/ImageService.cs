using System.Text.Json;
using instagrim.Models;

namespace instagrim.Services;

public class ImageService
{
    private HttpClient? _httpClient;
    
    private readonly SemaphoreSlim _httpClientQueue =  new SemaphoreSlim(1, 1);

    private async Task<HttpClient> GetClient()
    {
        await _httpClientQueue.WaitAsync();
        
        if (_httpClient is not null)
        {
            return _httpClient;
        }

        await using var stream = await FileSystem.OpenAppPackageFileAsync("ApiKey.txt");
        using var reader = new StreamReader(stream);

        var contents = await reader.ReadToEndAsync();
        
        var options = JsonSerializer.Deserialize<UnsplashOptions>(contents);

        _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://api.unsplash.com")
        };
        
        _httpClient.DefaultRequestHeaders.Add("Client-ID", options!.AccessKey);
        
        _httpClientQueue.Release();
        return _httpClient;
    }
}