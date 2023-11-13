using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Resenhapp.Repositories.Models;

namespace Resenhapp.Repositories.Data.Mappings;

public class PeopleMap : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();
        
        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(40);
        
        builder.Property(x => x.Instagram)
            .HasColumnType("VARCHAR")
            .HasMaxLength(40);    
        
        builder.Property(x => x.Age)
            .IsRequired();
        
        builder.Property(x => x.Gender)
            .IsRequired();
        
        builder.Property(x => x.PixKey)
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);

        // builder
        //     .HasOne(x => x.Partner)
        //     .WithOne(x => x.Partner);
    }
}