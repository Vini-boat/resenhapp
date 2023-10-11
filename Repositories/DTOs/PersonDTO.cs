namespace Resenhapp;

public class PersonDTO: NamedBaseDTO
{
    public string Instagram {get;set;} = string.Empty;
    public int Age {get;set;}
    public Gender Gender  {get;set;}
    public List<Gender>? SexualPreference {get; set;}
    public PersonDTO? Partner {get;set;}
    public string PixKey {get;set;} = string.Empty;
}