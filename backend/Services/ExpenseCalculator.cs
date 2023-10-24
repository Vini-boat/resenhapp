
namespace Resenhapp;

public class ExpenseCalculator : IExpenseCalculator
{
    public IDictionary<Person, int> GetPaiedTotal(Party party)
    {
        // var v = Person.persons.First(p => p.Name == "Vini"); // temp
        // var p = party.Expenses.Distinct(e => e.Owner == );
        // var dir = new Dictionary<Person,int>(); // temp
        // dir[v] = 1; // temp
        // return dir;

        throw new NotImplementedException();

    }

    public IDictionary<Person, int> GetPaiedTotal(List<Expense> expenses)
    {
        throw new NotImplementedException();
    }

    public IDictionary<Person, IDictionary<Person, int>> GetPayToWhoValues(Party party)
    {
        throw new NotImplementedException();
    }

    public IDictionary<Person, int> GetValuesToPay(Party party)
    {
        throw new NotImplementedException();
    }

    public IDictionary<Person, int> GetValuesToReceive(Party party)
    {
        throw new NotImplementedException();
    }
}