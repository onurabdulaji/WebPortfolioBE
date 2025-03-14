using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebPortfolio.Domain.Entities;

namespace WebPortfolio.Persistence.Configurations;
public class SummaryConfiguration : BaseConfiguration<Summary>
{
    public override void Configure(EntityTypeBuilder<Summary> builder)
    {
        base.Configure(builder);
    }
}