using Resenhapp.Repositories.Models;
namespace Resenhapp.Services.Interfaces;

public interface IUserService
{
    public Task<List<User>> GetAll();
    public Task<User?> GetById(int id);
    public Task Delete(User user);
    public Task Create(User user);
    public Task Update(User user);
}