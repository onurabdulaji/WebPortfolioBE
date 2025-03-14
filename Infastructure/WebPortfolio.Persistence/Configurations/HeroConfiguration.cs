using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebPortfolio.Domain.Entities;

namespace WebPortfolio.Persistence.Configurations;

public class HeroConfiguration : BaseConfiguration<Hero>
{
    public override void Configure(EntityTypeBuilder<Hero> builder)
    {
        base.Configure(builder);

        builder.Property(x => x.Title)
            .IsRequired();
        builder.Property(x => x.SubTitle)
            .IsRequired(); 
        builder.Property(x => x.BackgroundImageUrl)
            .IsRequired();
    }
}
