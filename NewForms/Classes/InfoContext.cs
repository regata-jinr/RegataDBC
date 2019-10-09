using Microsoft.EntityFrameworkCore;

namespace NewForms.Models
{
    public class InfoContext : DbContext
    {
        public static string ConnectionString;
        public DbSet<IrradiationInfo> Irradiations { get; set; }
        public DbSet<SampleSetInfo> table_Sample_set { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SampleSetInfo>()
                .HasKey(ssk => new { ssk.Country_Code,  ssk.Client_Id, ssk.Year, ssk.Sample_Set_Id, ssk.Sample_Set_Index});
        }
    }
}
