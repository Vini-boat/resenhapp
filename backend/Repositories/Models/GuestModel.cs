namespace Resenhapp;

public class Guest: Base
{
    public Person Person {get;set;} = new Person();
    public bool Invited  {get;set;}
    public bool Confirmed  {get;set;}
    public List<Person>? Agregates {get;set;}
    
    public static List<Guest> guests = new List<Guest> {
        new Guest {Id = 1, Person = Person.persons.First(p => p.Name == "Vini"), Invited = false, Confirmed = false},
        new Guest {Id = 2, Person = Person.persons.First(p => p.Name == "Amaral"), Invited = false, Confirmed = false},
        new Guest {Id = 3, Person = Person.persons.First(p => p.Name == "Yasmin"), Invited = false, Confirmed = false},
    };
}

