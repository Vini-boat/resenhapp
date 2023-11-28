namespace Resenhapp.Repositories.DTOs;

public class GuestDTO: BaseDTO
{
    public int? PersonId {get;set;}
    public bool Invited  {get;set;} = false;
    public bool Confirmed  {get;set;} = false;
    public List<int>? AgregatesIds {get;set;}    
}
