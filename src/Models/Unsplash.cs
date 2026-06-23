namespace instagrim.Models;

public class UnsplashResponse
{
    public int Total { get; set; }
    public int TotalPages { get; set; }
    public Results[]? Results { get; set; }
}

public class Results
{
    public string? Id { get; set; }
    public string? CreatedAt { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public string? Color { get; set; }
    public string? BlurHash { get; set; }
    public string? Description { get; set; }
    public User? User { get; set; }
    public object[]? CurrentUserCollections { get; set; }
    public Urls? Urls { get; set; }
    public Links? Links { get; set; }
}

public class User
{
    public string? Id { get; set; }
    public string? Username { get; set; }
    public string? Name { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? InstagramUsername { get; set; }
    public string? TwitterUsername { get; set; }
    public string? PortfolioUrl { get; set; }
    public ProfileImage? ProfileImage { get; set; }
    public Links? Links { get; set; }
}

public class ProfileImage
{
    public string? Small { get; set; }
    public string? Medium { get; set; }
    public string? Large { get; set; }
}

public class Urls
{
    public string? Raw { get; set; }
    public string? Full { get; set; }
    public string? Regular { get; set; }
    public string? Small { get; set; }
    public string? Thumb { get; set; }
}

public class Links
{
    public string? Self { get; set; }
    public string? Html { get; set; }
    public string? Download { get; set; }
}

// Converted from Json - uses the Unsplash API. See: https://unsplash.com/documentation#search-photos

/*
 *
 {
     "total": 133,
     "total_pages": 7,
     "results": [
       {
         "id": "eOLpJytrbsQ",
         "created_at": "2014-11-18T14:35:36-05:00",
         "width": 4000,
         "height": 3000,
         "color": "#A7A2A1",
         "blur_hash": "LaLXMa9Fx[D%~q%MtQM|kDRjtRIU",
         "description": "A man drinking a coffee.",
         "user": {
           "id": "Ul0QVz12Goo",
           "username": "ugmonk",
           "name": "Jeff Sheldon",
           "first_name": "Jeff",
           "last_name": "Sheldon",
           "instagram_username": "instantgrammer",
           "twitter_username": "ugmonk",
           "portfolio_url": "http://ugmonk.com/",
           "profile_image": {
             "small": "https://images.unsplash.com/profile-1441298803695-accd94000cac?ixlib=rb-0.3.5&q=80&fm=jpg&crop=faces&cs=tinysrgb&fit=crop&h=32&w=32&s=7cfe3b93750cb0c93e2f7caec08b5a41",
             "medium": "https://images.unsplash.com/profile-1441298803695-accd94000cac?ixlib=rb-0.3.5&q=80&fm=jpg&crop=faces&cs=tinysrgb&fit=crop&h=64&w=64&s=5a9dc749c43ce5bd60870b129a40902f",
             "large": "https://images.unsplash.com/profile-1441298803695-accd94000cac?ixlib=rb-0.3.5&q=80&fm=jpg&crop=faces&cs=tinysrgb&fit=crop&h=128&w=128&s=32085a077889586df88bfbe406692202"
           },
           "links": {
             "self": "https://api.unsplash.com/users/ugmonk",
             "html": "http://unsplash.com/@ugmonk",
             "photos": "https://api.unsplash.com/users/ugmonk/photos"
           }
         },
         "current_user_collections": [],
         "urls": {
           "raw": "https://images.unsplash.com/photo-1416339306562-f3d12fefd36f",
           "full": "https://hd.unsplash.com/photo-1416339306562-f3d12fefd36f",
           "regular": "https://images.unsplash.com/photo-1416339306562-f3d12fefd36f?ixlib=rb-0.3.5&q=80&fm=jpg&crop=entropy&cs=tinysrgb&w=1080&fit=max&s=92f3e02f63678acc8416d044e189f515",
           "small": "https://images.unsplash.com/photo-1416339306562-f3d12fefd36f?ixlib=rb-0.3.5&q=80&fm=jpg&crop=entropy&cs=tinysrgb&w=400&fit=max&s=263af33585f9d32af39d165b000845eb",
           "thumb": "https://images.unsplash.com/photo-1416339306562-f3d12fefd36f?ixlib=rb-0.3.5&q=80&fm=jpg&crop=entropy&cs=tinysrgb&w=200&fit=max&s=8aae34cf35df31a592f0bef16e6342ef"
         },
         "links": {
           "self": "https://api.unsplash.com/photos/eOLpJytrbsQ",
           "html": "http://unsplash.com/photos/eOLpJytrbsQ",
           "download": "http://unsplash.com/photos/eOLpJytrbsQ/download"
         }
       }
     ]
   }
 */