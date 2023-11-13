using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Resenhapp.Repositories.Models;

namespace Resenhapp.Repositories.Data.Mappings;

public class ItemsMap : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();
            
        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(40);
        
        builder.Property(x => x.Price)
            .IsRequired()
            .HasColumnType("REAL");

        builder.Property(x => x.Description)
            .HasColumnType("TEXT")
            .HasMaxLength(140)
            .HasDefaultValue("");
            
    }
}