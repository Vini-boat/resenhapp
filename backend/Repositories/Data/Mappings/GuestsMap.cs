using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Resenhapp.Migrations;
using Resenhapp.Repositories.Models;

namespace Resenhapp.Repositories.Data.Mappings;

public class GuestsMap : IEntityTypeConfiguration<Guest>
{
    public void Configure(EntityTypeBuilder<Guest> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();
        
        builder.HasOne(x => x.Person)
            .WithMany(x => x.GuestIn)
            .HasConstraintName("FK_GuestIn_Person")
            .OnDelete(DeleteBehavior.SetNull);
        
        builder.Property(x => x.Invited)
            .HasDefaultValue(false);
            
        builder.Property(x => x.Confirmed)
            .HasDefaultValue(false);
        
        builder.HasOne(x => x.Party)
            .WithMany(x => x.Guests)
            .HasConstraintName("FK_Guest_Party")
            .OnDelete(DeleteBehavior.Cascade);
        
        builder
            .HasMany(x => x.Agregates)
            .WithMany(x => x.AgregateFrom)
            .UsingEntity<Dictionary<string, object>>(
                "AgregateFromAgregate",
                agregateIn => agregateIn
                    .HasOne<Person>()
                    .WithMany()
                    .HasForeignKey("AgregateFromID")
                    .HasConstraintName("FK_AgregateFromRole_AgregateFromID")
                    .OnDelete(DeleteBehavior.SetNull),
                agregate => agregate
                    .HasOne<Guest>()
                    .WithMany()
                    .HasForeignKey("AgregateID")
                    .HasConstraintName("FK_AgregateFromAgregate_AgregateID")
                    .OnDelete(DeleteBehavior.SetNull)
            );
    }
}