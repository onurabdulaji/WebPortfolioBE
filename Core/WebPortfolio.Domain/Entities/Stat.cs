using WebPortfolio.Domain.Common.Concretes;

namespace WebPortfolio.Domain.Entities;

public class Stat : EntityBase
{
    public int? StatClient { get; set; }
    public int? StatProject { get; set; }
    public int? StatSupport { get; set; }
    public int? StatWorker { get; set; }
}
