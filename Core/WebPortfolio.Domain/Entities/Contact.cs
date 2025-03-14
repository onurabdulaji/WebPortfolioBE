using WebPortfolio.Domain.Common.Concretes;

namespace WebPortfolio.Domain.Entities;

public class Contact : EntityBase
{
    public string? ContactAddress { get; set; }
    public string? ContactPhone { get; set; }
    public string? ContactEmail { get; set; }
    public string? ContactMap { get; set; }
}
