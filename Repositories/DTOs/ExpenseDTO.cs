namespace Resenhapp;

public class ExpenseDTO: NamedBaseDTO
{
    public PersonDTO? Owner {get;set;}
    public double Value {get;set;}
    public DateTime Date {get;set;}
    public string Description {get;set;} = string.Empty;
    public bool Planned {get;set;}
    public bool Paied {get;set;}
}