namespace Resenhapp.Repositories.DTOs;

public class GuestDTO: BaseDTO
{
    public PersonDTO? Person {get;set;}
    public bool Invited  {get;set;} = false;
    public bool Confirmed  {get;set;} = false;
    public List<PersonDTO>? Agregates {get;set;}    
}
