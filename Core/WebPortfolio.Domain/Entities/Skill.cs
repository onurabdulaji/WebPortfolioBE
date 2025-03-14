using WebPortfolio.Domain.Common.Concretes;

namespace WebPortfolio.Domain.Entities;

public class Skill : EntityBase
{
    public string? SkillTitle { get; set; }
    public int? SkillValue { get; set; }
}
