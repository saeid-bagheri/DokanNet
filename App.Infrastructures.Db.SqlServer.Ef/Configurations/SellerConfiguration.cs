using App.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructures.Db.SqlServer.Ef.Configurations
{
    public class SellerConfiguration : IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> builder)
        {
            builder.Property(e => e.CardNumber).HasMaxLength(50);
            builder.Property(e => e.FeePercentage).HasColumnType("decimal(5, 2)");
            builder.Property(e => e.FirstName).HasMaxLength(50);
            builder.Property(e => e.LastName).HasMaxLength(50);
            builder.Property(e => e.Mobile).HasMaxLength(11);
            builder.Property(e => e.ShebaNumber).HasMaxLength(50);

            builder.HasOne(d => d.City).WithMany(p => p.Sellers)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sellers_Cities");

            builder.HasOne(d => d.Medal).WithMany(p => p.Sellers)
                .HasForeignKey(d => d.MedalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sellers_Medals");

            builder.HasOne(d => d.IdNavigation).WithOne(p => p.Seller)
                .HasForeignKey<Seller>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sellers_AppUsers");
        }
    }
}