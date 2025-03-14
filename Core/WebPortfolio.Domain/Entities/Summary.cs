using WebPortfolio.Domain.Common.Concretes;

namespace WebPortfolio.Domain.Entities;

public class Summary : EntityBase
{
    public string? SummaryName { get; set; }
    public string? SummaryDescription { get; set; }
    public string? SummaryAddress { get; set; }
    public string? SummaryPhone { get; set; }
    public string? SummaryEmail { get; set; }
}
