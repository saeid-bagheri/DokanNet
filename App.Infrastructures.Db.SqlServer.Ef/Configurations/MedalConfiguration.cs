using App.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructures.Db.SqlServer.Ef.Configurations
{
    public class MedalConfiguration : IEntityTypeConfiguration<Medal>
    {
        public void Configure(EntityTypeBuilder<Medal> builder)
        {
            builder.Property(e => e.Title).HasMaxLength(50);
        }
    }
}