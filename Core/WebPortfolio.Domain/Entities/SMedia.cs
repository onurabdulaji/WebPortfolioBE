using WebPortfolio.Domain.Common.Concretes;

namespace WebPortfolio.Domain.Entities;

public class SMedia : EntityBase
{
    public string? SMediaTitle { get; set; }
    public string? SMediaIcon { get; set; }
    public string? SMediaLink { get; set; }
}
