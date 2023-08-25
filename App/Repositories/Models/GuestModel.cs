namespace Resenhapp;

public class Guest: Base
{
    public Person? Person { get; set; }
    public bool Invited  {get;set;}
    public bool Confirmed  {get;set;}
    public List<Person>? Aggregates { get; set; }
}