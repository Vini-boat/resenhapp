namespace Resenhapp.Repositories.DTOs;

public class UserDTO: NamedBaseDTO
{
    public bool IsAdmin { get; set; } = false;
    public string? PassWord { get; set; }
    public string? Email { get; set; }
    // public List<PartyDTO>? Parties { get; set; }
}