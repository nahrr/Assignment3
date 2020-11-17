using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment3.Data
{

    public class JAContext : DbContext
    {
        public JAContext(DbContextOptions<JAContext> options) : 
            base(options)
        {
        }
        public DbSet<Models.Student> Students { get; set; }
        public DbSet<Models.Course> Courses { get; set; }
        public DbSet<Models.Module> Modules { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // kolla upp - watch out
        {
            modelBuilder.Entity<Models.Student>().ToTable("Student");
            modelBuilder.Entity<Models.Course>(e =>
            {
                //e.HasKey(x => x.CourseId);

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
        }

    }

}
