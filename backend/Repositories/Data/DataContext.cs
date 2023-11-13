using Microsoft.EntityFrameworkCore;
using Resenhapp.Migrations;
using Resenhapp.Repositories.Models;
using Resenhapp.Repositories.Data.Mappings;

namespace Resenhapp.Repositories.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {}

        public DbSet<Item> Items => Set<Item>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Party> Parties => Set<Party>();
        public DbSet<Guest> Guests => Set<Guest>();
        public DbSet<Person> People => Set<Person>();
        public DbSet<Expense> Expenses => Set<Expense>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ItemsMap());
            modelBuilder.ApplyConfiguration(new UsersMap());
            modelBuilder.ApplyConfiguration(new PartiesMap());
            modelBuilder.ApplyConfiguration(new GuestsMap());
            modelBuilder.ApplyConfiguration(new PeopleMap());
            modelBuilder.ApplyConfiguration(new ExpenseMap());
        }

    }
}