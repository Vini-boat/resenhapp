namespace Resenhapp;

public class Party: NamedBase
{
    public List<Guest>? Guests {get;set;}
    public List<Expense>? Expenses { get; set; }

    public static List<Party> parties = new List<Party>{
        new Party{
            Id = 1, 
            Name = "Festa Teste", 
            Guests = new List<Guest>{
                Guest.guests.First(g => g.Person.Name == "Vini"),
                Guest.guests.First(g => g.Person.Name == "Amaral"),
                Guest.guests.First(g => g.Person.Name == "Yasmin")
            },
            Expenses = new List<Expense>{
                Expense.expenses.First(e => e.Id == 1),
                Expense.expenses.First(e => e.Id == 2),
                Expense.expenses.First(e => e.Id == 3)
            }
            
        }
    };
}
