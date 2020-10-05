using Fruits.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fruits.Infra.ModelConfiguration
{
    public class TreeSpecieConfiguration : IEntityTypeConfiguration<TreeSpecie>
    {
        public void Configure(EntityTypeBuilder<TreeSpecie> builder)
        {
            builder.ToTable("TREE_SPECIE");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.Description).HasColumnName("DESCRIPTION");
        }
    }
}
