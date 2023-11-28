namespace Resenhapp.Repositories.Models;

public class Party: NamedBase
{
    public User? User { get; set; }
    public List<Guest> Guests {get;set;} = new List<Guest>();
    public List<Expense> Expenses { get; set; } = new List<Expense>();
}
