namespace Resenhapp;

public class Location: NamedBase
{
    public Person? Owner {get;set;}
    public int MaxCapacity {get;set;}
}
