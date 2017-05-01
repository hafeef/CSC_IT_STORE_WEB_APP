using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace CSC.Core.Common.Identity
{
    public partial class IdentityDataContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityDataContext() : base("StoreDBCS")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Identity");
            modelBuilder.Configurations.Add(new ApplicationUserDbConfigurations());
            base.OnModelCreating(modelBuilder);
        }
    }
}
