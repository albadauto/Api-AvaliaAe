using api_avaliaae.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_avaliaae.Data.Map
{
    public class UserMap : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(128);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(128);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(128);
            builder.Property(x => x.Number).IsRequired().HasMaxLength(32);
            builder.Property(x => x.Cpf).IsRequired().HasMaxLength(128);
            builder.Property(x => x.District).IsRequired().HasMaxLength(128);
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(128);
            builder.Property(x => x.Cep).IsRequired().HasMaxLength(128);
        }
    }
}
