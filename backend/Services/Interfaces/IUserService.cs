using Resenhapp.Repositories.DTOs;
namespace Resenhapp.Services.Interfaces;

public interface IUserService
{
    public Task<List<UserDTO>> GetAll();
    public Task<UserDTO?> GetById(int id);
    public Task DeleteById(int id);
    public Task Create(UserDTO user);
    public Task Update(UserDTO new_user);
}