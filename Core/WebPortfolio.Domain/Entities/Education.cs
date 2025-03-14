using WebPortfolio.Domain.Common.Concretes;

namespace WebPortfolio.Domain.Entities;

public class Education : EntityBase
{
    public string? EducationUniversityName { get; set; }
    public int? EducationUniversityFromDate { get; set; }
    public int? EducationUniversityFromToDate { get; set; }
    public string? EducationUniversityDegree { get; set; }
    public string? EducationUniversityDescription { get; set; }
}
