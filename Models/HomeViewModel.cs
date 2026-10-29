namespace DeepExecutive.Models;

public sealed class HomeViewModel
{
    public string Name { get; init; } = "";
    public string Designations { get; init; } = "";
    public string Positioning { get; init; } = "";
    public string Introduction { get; init; } = "";
    public IReadOnlyList<string> ProofPoints { get; init; } = Array.Empty<string>();
    public IReadOnlyList<CaseStudyCard> CaseStudies { get; init; } = Array.Empty<CaseStudyCard>();
}

public sealed record CaseStudyCard(string Title, string Category, string Summary);
