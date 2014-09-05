using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;

namespace WpfMvvmApplication1.Models
{
    class EFTest : DbContext
    {
        public DbSet<Children> Artists { get; set; }
        public DbSet<Family> Albums { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Map to the correct Chinook Database tables
            modelBuilder.Entity<Children>().ToTable("Children", "public");
            modelBuilder.Entity<Family>().ToTable("Family", "public");
        }
    }
}
