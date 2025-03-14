using WebPortfolio.Domain.Common.Abstracts;

namespace WebPortfolio.Domain.Common.Concretes;

public class EntityBase:IEntityBase
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime ModifiedDate { get; set; } = DateTime.UtcNow;
    public bool IsDeleted { get; set; } = false;
}
