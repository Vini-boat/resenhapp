namespace Resenhapp;

public class Party: NamedBase
{
    public Location? Location { get; set; }
    public DateTime Date { get; set; }
    public List<Guest>? Guests { get; set; }
    public List<Expense>? Expenses { get; set; }
}