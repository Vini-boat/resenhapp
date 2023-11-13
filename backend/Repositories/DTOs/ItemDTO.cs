namespace Resenhapp.Repositories.DTOs;

public class ItemDTO: NamedBaseDTO
{
    public double Price {get;set;}
    public string Description {get;set;} = string.Empty;
}