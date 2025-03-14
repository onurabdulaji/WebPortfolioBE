using WebPortfolio.Domain.Common.Concretes;

namespace WebPortfolio.Domain.Entities;

public class Hero:EntityBase
{
    public string? HeroTitle { get; set; }
    public string? HeroSubTitle { get; set; }
    public string? HeroBackgroundImageUrl { get; set; }
}
