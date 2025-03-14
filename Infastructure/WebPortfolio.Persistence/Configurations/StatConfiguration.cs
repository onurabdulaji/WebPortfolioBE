using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebPortfolio.Domain.Entities;

namespace WebPortfolio.Persistence.Configurations
{
    public class StatConfiguration : BaseConfiguration<Stat>
    {
        public override void Configure(EntityTypeBuilder<Stat> builder)
        {
            base.Configure(builder);
        }
    }
}
