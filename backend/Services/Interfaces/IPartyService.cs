using Resenhapp.Repositories.DTOs;
using Resenhapp.Repositories.Models;
namespace Resenhapp.Services.Interfaces;

public interface IPartyService
{
    public Task<List<Party>> GetAll();
    public Task<Party?> GetById(int id);
    public Task Delete(Party party);
    public Task<Party?> Create(PartyDTO party);
    public Task<List<Party>> GetByUserId(int id);
    public Task<Party?> AddGuest(int party_id, GuestDTO guest);
    public Task<Party?> AddExpense(int party_id, ExpenseDTO expense);
}