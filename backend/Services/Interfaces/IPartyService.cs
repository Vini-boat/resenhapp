using Resenhapp.Repositories.DTOs;
namespace Resenhapp.Services.Interfaces;

public interface IPartyService
{
    public Task<List<PartyDTO>> GetAll();
    public Task<PartyDTO?> GetById(int id);
    public Task DeleteById(int id);
    public Task<PartyDTO?> Create(PartyDTO party);
    public Task<List<PartyDTO>> GetByUserId(int id);
    public Task<PartyDTO?> AddGuest(int party_id, GuestDTO guest);
    public Task<PartyDTO?> AddExpense(int party_id, ExpenseDTO expense);
}