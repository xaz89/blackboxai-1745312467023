namespace DiadiaApp.Models;

public class Challenge
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public bool HasX2Badge { get; set; }
    public int Points { get; set; }
    public string ExpiryText { get; set; } = string.Empty;
    public int? Progress { get; set; }
    public int? Total { get; set; }
    public bool IsIconCard { get; set; }
    public string? IconClass { get; set; }
    public string? IconTitle { get; set; }
    public ChallengeStatus Status { get; set; }
}

public enum ChallengeStatus
{
    New,
    InProgress,
    Completed
}
