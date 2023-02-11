using api_avaliaae.Data.Map;
using api_avaliaae.Models;
using Microsoft.EntityFrameworkCore;

namespace api_avaliaae.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<UserModel> User { get; set; }
        public DbSet<InstitutionModel> Institution { get; set; }
        public DbSet<InstitutionTypeModel> InstitutionType { get; set; }
        public DbSet<AvaliationModel> Avaliations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new InstitutionMap());
            modelBuilder.ApplyConfiguration(new InstitutionTypeMap());
            modelBuilder.ApplyConfiguration(new AvaliationMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
