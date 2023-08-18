namespace App

public class Location
{
    public Guid Id {get;set;}
    public string Name {get;set;}
    public Person Owner {get;set;}
    public int MaxCapacity {get;set;}
}