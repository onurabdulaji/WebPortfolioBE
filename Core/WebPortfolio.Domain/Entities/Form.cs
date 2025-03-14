using WebPortfolio.Domain.Common.Concretes;

namespace WebPortfolio.Domain.Entities;

public class Form : EntityBase
{
    public string? FormName { get; set; }
    public string? FormEmail { get; set; }
    public string? FormSubject { get; set; }
    public string? FormMessage { get; set; }
    public string? FormSendDate { get; set; }
}
