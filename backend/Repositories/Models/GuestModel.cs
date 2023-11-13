namespace Resenhapp.Repositories.Models;

public class Guest: Base
{
    public Person? Person {get;set;}
    public bool Invited  {get;set;} = false;
    public bool Confirmed  {get;set;} = false;
    public List<Person>? Agregates {get;set;}
    public Party? Party {get;set;}
}

