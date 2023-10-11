namespace Resenhapp;

public class GuestDTO: BaseDTO
{
    public PersonDTO? Person {get;set;}
    public bool Invited  {get;set;}
    public bool Confirmed  {get;set;}
    public List<PersonDTO>? Agregates {get;set;}
    
}
