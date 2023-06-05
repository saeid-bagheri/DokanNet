using App.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace App.Infrastructures.Db.SqlServer.Ef.Configurations
{
    public class BuyerConfiguration : IEntityTypeConfiguration<Buyer>
    {
        public void Configure(EntityTypeBuilder<Buyer> builder)
        {
                builder.Property(e => e.FirstName).HasMaxLength(50);
                builder.Property(e => e.LastName).HasMaxLength(50);
                builder.Property(e => e.Mobile).HasMaxLength(11);

                builder.HasOne(d => d.City).WithMany(p => p.Buyers)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Buyers_Cities");

                builder.HasOne(x => x.AppUser).WithOne(x => x.Buyer);
        }
    }
}