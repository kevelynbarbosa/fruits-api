using Fruits.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fruits.Infra.ModelConfiguration
{
    class HarvestConfiguration : IEntityTypeConfiguration<Harvest>
    {
        public void Configure(EntityTypeBuilder<Harvest> builder)
        {
            builder.ToTable("HARVEST");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.Information).HasColumnName("INFORMATION");
            builder.Property(x => x.Date).HasColumnName("DATE");
            builder.Property(x => x.GrossWeight).HasColumnName("GROSS_WEIGHT");
            builder.Property(x => x.IdTree).HasColumnName("ID_TREE");

            builder.HasOne(x => x.Tree)
                .WithMany()
                .HasForeignKey(p => p.IdTree);
        }
    }
}
