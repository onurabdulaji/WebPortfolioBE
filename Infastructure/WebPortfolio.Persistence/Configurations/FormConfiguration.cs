using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebPortfolio.Domain.Entities;

namespace WebPortfolio.Persistence.Configurations;

public class FormConfiguration : BaseConfiguration<Form>
{
    public override void Configure(EntityTypeBuilder<Form> builder)
    {
        base.Configure(builder);
        builder.Property(x => x.FormName)
            .IsRequired();
        builder.Property(x => x.FormEmail)
            .IsRequired();
        builder.Property(x => x.FormSubject)
            .IsRequired();
        builder.Property(x => x.FormMessage)
            .IsRequired(); 
        builder.Property(x => x.FormSendDate)
            .IsRequired();
    }
}
