namespace App

public class Person 
{
    public Guid Id {get;set;}
    public string Name {get;set;}
    public string Instagram {get;set;}
    public int Age {get;set;}
    public gender Gender  {get;set;}
    public List<gender> SexualPreference {get; set;}
    public bool Invited  {get;set;}
    public bool Confirmed  {get;set;}
    public Person? Partner {get;set}
}