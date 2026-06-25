namespace instagrim.Models;

public class Post
{
    public required string Username { get; set; }

    public required string ImageUrl { get; set; }
    
    public string? AvatarUrl { get; set; }
    
    public DateTime? Posted { get; set; }

    public required string Location { get; set; }

    public required string Description { get; set; }

    public int Likes { get; set; }

    public int Comments { get; set; }

    public bool IsLiked { get; set; }

    public bool IsFavourite { get; set; }
}