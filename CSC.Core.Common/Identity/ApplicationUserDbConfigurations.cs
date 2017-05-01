using System.Data.Entity.ModelConfiguration;

namespace CSC.Core.Common.Identity
{
    public class ApplicationUserDbConfigurations : EntityTypeConfiguration<ApplicationUser>
    {
        public ApplicationUserDbConfigurations()
        {
            Property(u => u.FirstName).IsRequired().HasMaxLength(30).HasColumnType("varchar");
            Property(u => u.LastName).IsRequired().HasMaxLength(30).HasColumnType("varchar");
            Property(u => u.Gender).IsRequired().HasColumnType("tinyint");
        }
    }
}
