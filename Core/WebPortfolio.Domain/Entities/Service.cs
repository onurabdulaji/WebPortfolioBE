using WebPortfolio.Domain.Common.Concretes;

namespace WebPortfolio.Domain.Entities;

public class Service : EntityBase
{
    public string? ServiceTitle { get; set; }
    public string? ServiceDescription { get; set; }
    public string? ServiceIcon { get; set; }
}
