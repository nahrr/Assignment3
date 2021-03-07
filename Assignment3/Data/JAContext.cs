using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment3.Data
{

    /* EntityFramework
     * Skapar databastabeller (In Memory) och databaskopplingar
     */

    public class JAContext : DbContext
    {
        public JAContext(DbContextOptions<JAContext> options) : base(options)
        {

        }

        public DbSet<Models.Student> Students { get; set; }
        public DbSet<Models.Course> Courses { get; set; }
        public DbSet<Models.Module> Modules { get; set; }
        public DbSet<Models.Ladok> LadokDb { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Student>().ToTable("Students");
            modelBuilder.Entity<Models.Course>(e =>
            {
                e.HasMany(x => x.Modules)
                    .WithOne(x => x.Course);
              
                e.ToTable("Courses");
           
            });
            modelBuilder.Entity<Models.Module>(e =>
            {
                e.HasOne(x => x.Course)
                    .WithMany(x => x.Modules);
                
                e.ToTable("Modules");
            });
            modelBuilder.Entity<Models.Ladok>(e =>
            {
                e.HasKey(x => x.LadokId);

                e.ToTable("LadokDb");
            });
           



        }

    }

}
