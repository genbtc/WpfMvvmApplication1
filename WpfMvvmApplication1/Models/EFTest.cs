using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using WpfMvvmApplication1.Helpers;

namespace WpfMvvmApplication1.Models
{
    class ChildrenContext : DbContext
    {
        private DbSet<ChildrenDB> CHILDREN;
        private DbSet<FamilyDB> FAMILY;

        public DbSet<ChildrenDB> Children
        {
            get { return CHILDREN; }
            set { CHILDREN = value; }
        }

        public DbSet<FamilyDB> Family
        {
            get { return FAMILY; }
            set { FAMILY = value; }
            //set
            //{
            //    if (FAMILY != value)
            //    {
            //        FAMILY = value;
            //        RaisePropertyChanged(() => Family);
            //    }
            //}
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Map to the correct Database tables
            modelBuilder.Entity<ChildrenDB>().ToTable("CHILDRENS", "public");
            modelBuilder.Entity<FamilyDB>().ToTable("FAMILIES", "public");
        }


        protected void RaisePropertyChanged<T>(Expression<Func<T>> action)
        {
            var propertyName = GetPropertyName(action);
            RaisePropertyChanged(propertyName);
        }

        private static string GetPropertyName<T>(Expression<Func<T>> action)
        {
            var expression = (MemberExpression)action.Body;
            var propertyName = expression.Member.Name;
            return propertyName;
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
