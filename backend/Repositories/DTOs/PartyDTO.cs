namespace Resenhapp.Repositories.DTOs;

public class PartyDTO: NamedBaseDTO
{
    // public UserDTO? User { get; set; }
    public int UserId { get; set; }
    public List<GuestDTO>? Guests {get;set;}
    public List<ExpenseDTO>? Expenses { get; set; }
}