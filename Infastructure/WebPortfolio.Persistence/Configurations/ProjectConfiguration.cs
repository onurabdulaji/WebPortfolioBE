using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebPortfolio.Domain.Entities;

namespace WebPortfolio.Persistence.Configurations;

public class ProjectConfiguration : BaseConfiguration<Project>
{
    public override void Configure(EntityTypeBuilder<Project> builder)
    {
        base.Configure(builder);
        builder.Property(x => x.Title)
            .IsRequired();
    }
}
