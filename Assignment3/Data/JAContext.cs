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

        protected override void OnModelCreating(ModelBuilder modelBuilder) // kolla upp
        {
            modelBuilder.Entity<Models.Student>().ToTable("Student");
        }

    }

}
