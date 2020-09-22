using Microsoft.EntityFrameworkCore;

namespace Extensions.Models
{
    public class InfoContext : DbContext
    {
        public DbSet<Sample>      Samples { get; set; }
        public DbSet<SetInfo>     Sets    { get; set; }
        public DbSet<SampleTypes> Types   { get; set; }
        public DbSet<ScRecord>    Records { get; set; }


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
            modelBuilder.Entity<SetInfo>()
                   .HasKey(s => new { s.Country_Code, s.Client_ID, s.Year, s.Sample_Set_ID, s.Sample_Set_Index });

            modelBuilder.Entity<Sample>()
                 .HasKey(s => new { s.F_Country_Code, s.F_Client_Id, s.F_Year, s.F_Sample_Set_Id, s.F_Sample_Set_Index, s.A_Sample_ID });

            modelBuilder.Entity<SampleTypes>().HasKey(t => new { t.Type, t.SubType });

            modelBuilder.Entity<ScRecord>()
                .HasKey(s => new { s.SampleSet, s.Sample_ID });
        }
    }
}
