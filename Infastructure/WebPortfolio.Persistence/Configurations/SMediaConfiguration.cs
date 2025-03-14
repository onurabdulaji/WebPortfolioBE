using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebPortfolio.Domain.Entities;

namespace WebPortfolio.Persistence.Configurations
{
    public class SMediaConfiguration : BaseConfiguration<SMedia>
    {
        public override void Configure(EntityTypeBuilder<SMedia> builder)
        {
            base.Configure(builder);
        }
    }
}
