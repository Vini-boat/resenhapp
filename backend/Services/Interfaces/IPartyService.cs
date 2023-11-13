using Resenhapp.Repositories.Models;
namespace Resenhapp.Services.Interfaces;

public interface IPartyService
{
    public Task<List<Party>> GetAll();
    public Task<Party?> GetById(int id);
    public Task Delete(Party party);
    public Task Create(Party party);
    public Task Update(Party new_party);
    public Task<List<Party>> GetByUserId(int id);
}