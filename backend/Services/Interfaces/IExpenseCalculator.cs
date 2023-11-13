using Resenhapp.Repositories.Models;
namespace Resenhapp.Services.Interfaces;

public interface IExpenseCalculator
{
    public IDictionary<Person, int> GetPaiedTotal(Party party);
    public IDictionary<Person, int> GetPaiedTotal(List<Expense> expenses);
    public IDictionary<Person, int> GetValuesToPay(Party party);
    public IDictionary<Person, int> GetValuesToReceive(Party party);
    public IDictionary<Person, IDictionary<Person, int>> GetPayToWhoValues(Party party);
}