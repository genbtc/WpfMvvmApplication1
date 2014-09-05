using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;

namespace WpfMvvmApplication1.Models
{
    class ChildrenContext : DbContext
    {
        public DbSet<ChildrenDB> Children { get; set; }
        public DbSet<FamilyDB> Family { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Map to the correct Chinook Database tables
            modelBuilder.Entity<ChildrenDB>().ToTable("CHILDRENS", "public");
            modelBuilder.Entity<FamilyDB>().ToTable("FAMILIES", "public");
        }
    }
}
