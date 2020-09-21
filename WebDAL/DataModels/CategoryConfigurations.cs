using System.Data.Entity.ModelConfiguration;

namespace WebDAL.DataModels
{
    internal class CategoryConfigurations : EntityTypeConfiguration<Product>
    {
        public CategoryConfigurations()
        {
            this.Property(s => s.Id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(s => s.Name)
                .IsConcurrencyToken();

            
        }
    }
}