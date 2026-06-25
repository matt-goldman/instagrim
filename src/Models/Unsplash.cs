namespace instagrim.Models;

// Converted from Json - uses the Unsplash API. See: https://unsplash.com/documentation#search-photos

public class UnsplashResponse
{
    public int Total { get; set; }
    public int TotalPages { get; set; }
    public Results[] Results { get; set; } = [];
}

public class Results
{
    public required string Id { get; set; }
    public AlternativeSlugs? AlternativeSlugs { get; set; }
    public required string CreatedAt { get; set; }
    public required string UpdatedAt { get; set; }
    public string? PromotedAt { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public string? Color { get; set; }
    public string? BlurHash { get; set; }
    public required string Description { get; set; }
    public object[]? Breadcrumbs { get; set; }
    public required Urls Urls { get; set; }
    public int Likes { get; set; }
    public bool LikedByUser { get; set; }
    public bool Bookmarked { get; set; }
    public object[]? CurrentUserCollections { get; set; }
    public object? Sponsorship { get; set; }
    public TopicSubmissions? TopicSubmissions { get; set; }
    public string? AssetType { get; set; }
    public string? Slug { get; set; }
    public string? AltDescription { get; set; }
    public required Links Links { get; set; }
    public required User User { get; set; }
}

public class AlternativeSlugs
{
    public string? En { get; set; }
    public string? Es { get; set; }
    public string? Ja { get; set; }
    public string? Fr { get; set; }
    public string? It { get; set; }
    public string? Ko { get; set; }
    public string? De { get; set; }
    public string? Pt { get; set; }
    public string? Id { get; set; }
}

public class Urls
{
    public required string Raw { get; set; }
    public required string Full { get; set; }
    public required string Regular { get; set; }
    public required string Small { get; set; }
    public required string Thumb { get; set; }
    public required string SmallS3 { get; set; }
}

public class TopicSubmissions
{
    public Night? Night { get; set; }
    public Nature? Nature { get; set; }
    public Wallpapers? Wallpapers { get; set; }
}

public class Night
{
    public string? Status { get; set; }
    public string? ApprovedOn { get; set; }
}

public class Nature
{
    public string? Status { get; set; }
    public string? ApprovedOn { get; set; }
}

public class Wallpapers
{
    public string? Status { get; set; }
    public string? ApprovedOn { get; set; }
}

public class Links
{
    public required string Self { get; set; }
    public required string Html { get; set; }
    public required string Download { get; set; }
    public required string DownloadLocation { get; set; }
}

public class User
{
    public required string Id { get; set; }
    public required string UpdatedAt { get; set; }
    public required string Username { get; set; }
    public string? Name { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? TwitterUsername { get; set; }
    public string? PortfolioUrl { get; set; }
    public string? Bio { get; set; }
    public string? Location { get; set; }
    public Links? Links { get; set; }
    public ProfileImage? ProfileImage { get; set; }
    public string? InstagramUsername { get; set; }
    public int TotalCollections { get; set; }
    public int TotalLikes { get; set; }
    public int TotalPhotos { get; set; }
    public int TotalFreePhotos { get; set; }
    public int TotalPromotedPhotos { get; set; }
    public int TotalIllustrations { get; set; }
    public int TotalFreeIllustrations { get; set; }
    public int TotalPromotedIllustrations { get; set; }
    public bool AcceptedTos { get; set; }
    public bool ForHire { get; set; }
    public Social? Social { get; set; }
}

public class ProfileImage
{
    public string? Small { get; set; }
    public string? Medium { get; set; }
    public string? Large { get; set; }
}

public class Social
{
    public string? InstagramUsername { get; set; }
    public string? PortfolioUrl { get; set; }
    public string? TwitterUsername { get; set; }
    public object? PaypalEmail { get; set; }
}
