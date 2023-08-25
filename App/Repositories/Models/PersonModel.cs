namespace Resenhapp;

public class Person: NamedBase
{
    public string? Instagram {get;set;}
    public int Age {get;set;}
    public Gender Gender  {get;set;}
    public List<Gender>? SexualPreference {get; set;}
    public Person? Partner { get; set; }
}