using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebPortfolio.Domain.Entities;

namespace WebPortfolio.Persistence.Configurations;

public class AboutConfiguration : BaseConfiguration<About>
{
    public override void Configure(EntityTypeBuilder<About> builder)
    {
        base.Configure(builder);
        builder.Property(a => a.Title)
           .HasMaxLength(150)
           .IsRequired();
    }
}
