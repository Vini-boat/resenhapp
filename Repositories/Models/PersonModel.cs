namespace Resenhapp;

public class Person: NamedBase
{
    public string? Instagram {get;set;}
    public int Age {get;set;}
    public Gender Gender  {get;set;}
    public List<Gender>? SexualPreference {get; set;}
    public Person? Partner {get;set;}
    public string PixKey { get; set; } = string.Empty;

    public static List<Person> persons = new List<Person> 
    {
        new Person{Id = 1, Name = "Vini", Instagram = "@bezeraa_vini", Age = 19, Gender = Gender.Male},
        new Person{Id = 2, Name = "Vini2", Instagram = "", Age = 19, Gender = Gender.Male},
        new Person{Id = 3, Name = "Amaral", Instagram = "", Age = 19, Gender = Gender.Male},
        new Person{Id = 4, Name = "Yasmin", Instagram = "", Age = 17, Gender = Gender.Female}
    };
}
