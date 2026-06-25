namespace instagrim.ViewModels;

public class StoryViewModel
{
    public bool IsMe { get; set; } = false;

    public required string Username { get; set; }

    public required string Avatar { get; set; }

    public bool BorderActive { get; set; }

    public bool GlowActive { get; set; }
}