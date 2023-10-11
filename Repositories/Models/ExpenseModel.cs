namespace Resenhapp;

public class Expense: NamedBase
{
    public Person? Owner {get;set;}
    public double Value {get;set;}
    public DateTime Date {get;set;}
    public string Description {get;set;} = string.Empty;
    public bool Planned {get;set;}
    public bool Paied {get;set;}

    public static List<Expense> expenses = new List<Expense>{
        new Expense{
            Id = 1, 
            Name = "Gasolina", 
            Value = 100.00 ,
            Owner = Person.persons.First(p => p.Name == "Vini"),
            Paied = true
        },
        new Expense{Id = 2, Name = "Bebidas", Value = 60.00 ,Owner = Person.persons.First(p => p.Name == "Amaral"), Paied = true},
        new Expense{Id = 3, Name = "Burguer King", Value = 90.00 ,Owner = Person.persons.First(p => p.Name == "Yasmin"), Paied = true},
        new Expense{Id = 4, Name = "Pedágio", Value = 10.00 ,Owner = Person.persons.First(p => p.Name == "Vini"), Paied = true}
    };
}