using WebPortfolio.Domain.Common.Concretes;

namespace WebPortfolio.Domain.Entities;

public class Project : EntityBase
{
    public string? ProjectTitle { get; set; }
    public string? ProjectDescription { get; set; }
    public string? ProjectSmallImage { get; set; }
    public string? ProjectCategory { get; set; }
    public string? ProjectClient { get; set; }
    public DateTime? ProjectDate { get; set; }
    public string? ProjectLink { get; set; }
    public string? ProjectImage1 { get; set; }
    public string? ProjectImage2 { get; set; }
    public string? ProjectImage3 { get; set; }
    public string? ProjectImage4 { get; set; }

}
