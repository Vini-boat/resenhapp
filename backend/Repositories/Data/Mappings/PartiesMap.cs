using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Resenhapp.Repositories.Models;

namespace Resenhapp.Repositories.Data.Mappings;

public class PartiesMap : IEntityTypeConfiguration<Party>
{
    public void Configure(EntityTypeBuilder<Party> builder)
    {
        // Propriedades
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(40);
        
        // Relacionamentos
        builder
            .HasOne(x => x.User)
            .WithMany(x => x.Parties)
            .HasConstraintName("FK_Party_User")
            .OnDelete(DeleteBehavior.Cascade);
        
        builder
            .HasMany(x => x.Guests)
            .WithOne(x => x.Party)
            .HasConstraintName("FK_Guest_Party")
            .OnDelete(DeleteBehavior.Cascade);
        
        builder
            .HasMany(x => x.Expenses)
            .WithOne(x => x.Party)
            .HasConstraintName("FK_Expense_Party")
            .OnDelete(DeleteBehavior.Cascade);

    }
}