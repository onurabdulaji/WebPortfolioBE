using WebPortfolio.Domain.Common.Concretes;

namespace WebPortfolio.Domain.Entities;

public class Skill : EntityBase
{
    public string? Title { get; set; }
    public int? Value { get; set; }
    public Skill()
    {
    }
    public Skill(string title , int value)
    {
        Title = title;
        Value = value;
    }
}
