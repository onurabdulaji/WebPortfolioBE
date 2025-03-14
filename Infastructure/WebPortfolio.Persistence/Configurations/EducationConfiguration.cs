using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebPortfolio.Domain.Entities;

namespace WebPortfolio.Persistence.Configurations;

public class EducationConfiguration :BaseConfiguration<Education>
{
    public override void Configure(EntityTypeBuilder<Education> builder)
    {
        base.Configure(builder);
        builder.Property(e => e.Name)
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(e => e.FromYear)
            .IsRequired();

        builder.Property(e => e.ToYear)
            .IsRequired();

        builder.Property(e => e.Degree)
            .IsRequired();

        builder.Property(e => e.Description)
            .IsRequired();
    }
}
