using api_avaliaae.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_avaliaae.Data.Map
{
    public class InstitutionTypeMap : IEntityTypeConfiguration<InstitutionTypeModel>
    {
        public void Configure(EntityTypeBuilder<InstitutionTypeModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);


        }
    }
}
