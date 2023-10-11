namespace Resenhapp;

public class PartyDTO: NamedBaseDTO
{
    public List<GuestDTO>? Guests {get;set;}
    public List<ExpenseDTO>? Expenses { get; set; }
}