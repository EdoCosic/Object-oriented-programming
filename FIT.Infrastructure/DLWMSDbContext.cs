using FIT.Data;
using FIT.Data.IspitIB210181;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
    
        public DbSet<Student> Studenti { get; set; }
        public DbSet<NastavaIB210181> NastavaIB210181 { get; set; }
        public DbSet<ProstorijeIB210181> ProstorijeIB210181 { get; set; }
        public DbSet<PrisustvoIB210181> PrisustvoIB210181 { get; set; }
        public DbSet<PredmetiIB210181> Predmeti { get; set; }

    }
}