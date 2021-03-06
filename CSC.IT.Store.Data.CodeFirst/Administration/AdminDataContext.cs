﻿using CSC.IT.Store.Data.CodeFirst.Administration.DbConfigurations;
using CSC.IT.Store.Domain.Classes.Administration;
using System.Data.Entity;

namespace CSC.IT.Store.Data.CodeFirst.Administration
{
    public class AdminDataContext : DbContext
    {
        public AdminDataContext() : base("StoreDBCS")
        {

        }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Administration");
            modelBuilder.Configurations.Add(new BrandDbConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
