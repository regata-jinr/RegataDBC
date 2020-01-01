using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer;

namespace NewForms.Models
{
    public class InfoContext : DbContext
    {
        public static string ConnectionString;

        public DbSet<IrradiationInfo>   Irradiations      { get; set; }
        public DbSet<SampleSetInfo>     SampleSets        { get; set; }
        public DbSet<SampleInfo>        Samples           { get; set; }
        public DbSet<StandardInfo>      Standards         { get; set; }
        public DbSet<LastSrmIrrInfo>    NewStandards      { get; set; }
        public DbSet<StandardSetInfo>   StandardSets      { get; set; }
        public DbSet<MonitorInfo>       Monitors          { get; set; }
        public DbSet<MonitorSetInfo>    MonitorSets       { get; set; }

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

            modelBuilder.Entity<StandardSetInfo>()
             .HasKey(ss => new { ss.SRM_Set_Name, ss.SRM_Set_Number });

            modelBuilder.Entity<StandardInfo>()
             .HasKey(ss => new { ss.SRM_Number });

            modelBuilder.Entity<LastSrmIrrInfo>()
            .HasKey(ss => new { ss.SRM_Number });

            modelBuilder.Entity<MonitorSetInfo>()
             .HasKey(ss => new { ss.Monitor_Set_Name, ss.Monitor_Set_Number });

            modelBuilder.Entity<MonitorInfo>()
             .HasKey(ss => new { ss.Monitor_Set_Name, ss.Monitor_Set_Number, ss.Monitor_Number });
        }
    }
}
