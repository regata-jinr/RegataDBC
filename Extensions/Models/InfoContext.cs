using Microsoft.EntityFrameworkCore;

namespace Extensions.Models
{
   public class InfoContext : DbContext
    {
        public DbSet<SampleInfo> Samples { get; set; }
        public DbSet<SampleSetInfo> Sets { get; set; }

        private readonly string connectionString;
        public InfoContext(string connectionString) : base()
        {
            this.connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SampleInfo>()
                    .HasKey(s => new { s.F_Country_Code, s.F_Client_Id, s.F_Year, s.F_Sample_Set_Id, s.F_Sample_Set_Index, s.A_Sample_ID });
        }
    }
}
