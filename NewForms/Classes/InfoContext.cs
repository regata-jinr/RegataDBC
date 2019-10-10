using Microsoft.EntityFrameworkCore;

namespace NewForms.Models
{
    public class InfoContext : DbContext
    {
        public static string ConnectionString;
        public DbSet<IrradiationInfo> Irradiations { get; set; }
        public DbSet<SampleSetInfo> SampleSets { get; set; }
        public DbSet<SampleInfo> Samples { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SampleSetInfo>()
                .HasKey(ssk => new { ssk.Country_Code,  ssk.Client_Id, ssk.Year, ssk.Sample_Set_Id, ssk.Sample_Set_Index});

            modelBuilder.Entity<SampleInfo>()
                .HasKey(sk => new { sk.F_Country_Code, sk.F_Client_Id, sk.F_Year, sk.F_Sample_Set_Id, sk.F_Sample_Set_Index, sk.A_Sample_ID });
        }
    }
}
