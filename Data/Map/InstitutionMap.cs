using api_avaliaae.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_avaliaae.Data.Map
{
    public class InstitutionMap : IEntityTypeConfiguration<InstitutionModel>
    {
        public void Configure(EntityTypeBuilder<InstitutionModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Email);
            builder.Property(x => x.District);
            builder.Property(x => x.Description);
            builder.Property(x => x.Cnpj);
            builder.Property(x => x.Cep);
            builder.Property(x => x.Address);
            builder.Property(x => x.District);
            builder.Property(x => x.Number);

        }
    }
}
