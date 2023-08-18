namespace App

public class Expense
{
    public Guid Id {get;set;}
    public Person Owner {get;set;}
    public string Name {get;set;}
    public double Value {get;set;}
    public datetime date {get;set}
    public string Description {get;set;}
    public bool Planned {get;set;}
    public bool Paied {get;set;}
}