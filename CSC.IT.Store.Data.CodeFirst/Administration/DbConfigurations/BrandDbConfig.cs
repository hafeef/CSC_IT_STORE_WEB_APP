using CSC.IT.Store.Domain.Classes.Administration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace CSC.IT.Store.Data.CodeFirst.Administration.DbConfigurations
{
    public class BrandDbConfig : EntityTypeConfiguration<Brand>
    {
        public BrandDbConfig()
        {
            HasKey(b => b.BrandId);

            Property(b => b.BrandName).IsRequired()
                .HasMaxLength(40).HasColumnType("varchar").HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute() { IsUnique = true }));

            Property(b => b.CreatedDateTime).IsOptional().HasColumnType("smalldatetime");
            Property(b => b.ModifiedDateTime).IsOptional().HasColumnType("smalldatetime");
            Property(b => b.CreatedBy).IsOptional().HasMaxLength(100).HasColumnType("varchar");

        }
    }
}
