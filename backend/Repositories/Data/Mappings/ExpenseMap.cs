using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Resenhapp.Repositories.Models;

namespace Resenhapp.Repositories.Data.Mappings;

public class ExpenseMap : IEntityTypeConfiguration<Expense>
{
    public void Configure(EntityTypeBuilder<Expense> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();
        
        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(40);

        builder.Property(x => x.Description)
            .IsRequired()
            .HasColumnType("TEXT")
            .HasMaxLength(140);
        
        builder.Property(x => x.Value)
            .IsRequired()
            .HasColumnType("REAL");
        
        builder.Property(x => x.Date)
            .IsRequired()
            .HasColumnType("SMALLDATETIME")
            .HasMaxLength(60)
            .HasDefaultValueSql("GETDATE()");
        
        builder.Property(x => x.Planned)
            .HasDefaultValue(true);

        builder.Property(x => x.Paied)
            .HasDefaultValue(false);
        
        builder
            .HasOne(x => x.Owner)
            .WithMany(x => x.Expenses)
            .HasConstraintName("FK_Expense_Owner")
            .OnDelete(DeleteBehavior.Cascade);
        

    }
}