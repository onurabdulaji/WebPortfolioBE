using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebPortfolio.Domain.Entities;

namespace WebPortfolio.Persistence.Configurations;

public class EducationConfiguration :BaseConfiguration<Education>
{
    public override void Configure(EntityTypeBuilder<Education> builder)
    {
        base.Configure(builder);
        builder.Property(a => a.Name)
            .HasMaxLength(256)
            .IsRequired();
    }
}s
