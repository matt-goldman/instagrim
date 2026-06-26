namespace instagrim.Models;

public class SocialUpdate
{
    public required string Username { get; set; }

    public required string Avatar { get; set; }

    public bool Liked { get; private set; }

    public bool Screamed { get; private set; }

    public bool Haunted { get; private set; }

    public int AdditionalScreams { get; set; }

    public string Scream { get; set; } = string.Empty;

    public void SetLiked()
    {
        Liked = true;
        Screamed = false;
        Haunted = false;
    }

    public void SetScreamed(string scream, int? additionalScreams = 0)
    {
        Screamed = true;
        Liked = false;
        Haunted = false;
        Scream = scream;
        AdditionalScreams = additionalScreams??0;
    }

    public void SetHaunted()
    {
        Haunted = true;
        Liked = false;
        Screamed = false;
    }
}