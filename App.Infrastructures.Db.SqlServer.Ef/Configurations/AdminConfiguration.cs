using App.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace App.Infrastructures.Db.SqlServer.Ef.Configurations
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.Property(e => e.CardNumber).HasMaxLength(50);
            builder.Property(e => e.ShebaNumber).HasMaxLength(50);

            builder.HasOne(x => x.AppUser).WithOne(x => x.Admin);
        }
    }
}