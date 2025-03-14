using WebPortfolio.Domain.Common.Concretes;

namespace WebPortfolio.Domain.Entities;

public class Resume : EntityBase
{
    public string? ResumeCompanyTitle { get; set; }
    public string? ResumeCompanyCity { get; set; }
    public int? ResumeCompanyYearsFromDate { get; set; }
    public int? ResumeCompanyYearsFromToDate { get; set; }
    public string? ResumeCompanyResponsibleTitle1 { get; set; }
    public string? ResumeCompanyResponsibleTitle2 { get; set; }
    public string? ResumeCompanyResponsibleTitle3 { get; set; }
    public string? ResumeCompanyResponsibleTitle4 { get; set; }
    public string? ResumeCompanyResponsibleTitle5 { get; set; }
    public string? ResumeCompanyResponsibleTitle6 { get; set; }
}
