using api_avaliaae.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_avaliaae.Data.Map
{
    public class AvaliationMap : IEntityTypeConfiguration<AvaliationModel>
    {
        public void Configure(EntityTypeBuilder<AvaliationModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Comment);
            builder.Property(x => x.Note);

        }
    }
}
