using api_avaliaae.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_avaliaae.Data.Map
{
    public class ApiLoginMap : IEntityTypeConfiguration<ApiLoginModel>
    {
        public void Configure(EntityTypeBuilder<ApiLoginModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Login);
            builder.Property(x => x.Password);
        }
    }
}
