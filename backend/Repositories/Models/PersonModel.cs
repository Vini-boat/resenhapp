using Resenhapp.Repositories.Enums;
namespace Resenhapp.Repositories.Models;

public class Person: NamedBase
{
    public string? Instagram {get;set;}
    public int Age {get;set;}
    public Gender Gender  {get;set;}
    // public Person? Partner {get;set;}
    public string PixKey { get; set; } = string.Empty;
    
    public List<Guest>? GuestIn { get; set; }
    public List<Guest>? AgregateFrom { get; set; }
    public List<Expense>? Expenses { get; set; }
}
