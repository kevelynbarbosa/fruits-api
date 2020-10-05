using Fruits.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fruits.Infra.ModelConfiguration
{
    public class TreeConfiguration : IEntityTypeConfiguration<Tree>
    {
        public void Configure(EntityTypeBuilder<Tree> builder)
        {
            builder.ToTable("TREE");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.Description).HasColumnName("DESCRIPTION");
            builder.Property(x => x.Age).HasColumnName("AGE");
            builder.Property(x => x.IdTreeSpecie).HasColumnName("ID_TREE_SPECIE");
            builder.Property(x => x.IdTreeGroup).HasColumnName("ID_TREE_GROUP");

            builder.HasOne(x => x.TreeSpecie)
                .WithMany()
                .HasForeignKey(p => p.IdTreeSpecie);

            builder.HasOne(x => x.TreeGroup)
                .WithMany()
                .HasForeignKey(p => p.IdTreeGroup);
        }
    }
}
