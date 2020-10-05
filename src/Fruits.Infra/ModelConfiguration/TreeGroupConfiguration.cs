using Fruits.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fruits.Infra.ModelConfiguration
{
    class TreeGroupConfiguration : IEntityTypeConfiguration<TreeGroup>
    {
        public void Configure(EntityTypeBuilder<TreeGroup> builder)
        {
            builder.ToTable("TREE_GROUP");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.Name).HasColumnName("NAME");
            builder.Property(x => x.Description).HasColumnName("DESCRIPTION");
        }
    }
}
