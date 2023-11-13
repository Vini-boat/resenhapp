using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Resenhapp.Repositories.Models;

namespace Resenhapp.Repositories.Data.Mappings;

public class UsersMap : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();
        
        builder.Property(x => x.PassWord)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(30);
        
        builder.Property(x => x.Email)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(50);
    }
}