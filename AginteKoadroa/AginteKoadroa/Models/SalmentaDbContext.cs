using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AginteKoadroa.Models //Beti berdina da
{
    internal class SalmentaDbContext : DbContext
    {
        public SalmentaDbContext() : base(nameOrConnectionString: "SalmentaDbContext") //APP config-eko izen berdina izan behar da. Bakarrik hau ikutu.
        { }
        public DbSet<Bezeroa> Bezeroa { get; set; }
        public DbSet<Salmenta> Salmenta { get; set; }
        public DbSet<Saltzailea> Saltzailea { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
