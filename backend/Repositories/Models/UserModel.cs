namespace Resenhapp.Repositories.Models;

public class User: NamedBase
{
    public bool IsAdmin { get; set; } = false;
    public string? PassWord { get; set; }
    public string? Email { get; set; }
    public List<Party>? Parties { get; set; }
}