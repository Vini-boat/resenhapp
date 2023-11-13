namespace Resenhapp.Repositories.Models;

public class Expense: NamedBase
{
    public double Value {get;set;}
    public Person? Owner {get;set;}
    public DateTime Date {get;set;}
    public string Description {get;set;} = string.Empty;
    public bool? Planned {get;set;}
    public bool? Paied {get;set;}
    public Party? Party {get; set;}
}