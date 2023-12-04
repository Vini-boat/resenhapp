using Resenhapp.Repositories.DTOs;
namespace Resenhapp.Services.Interfaces;

public interface IItemService
{
    public Task<List<ItemDTO>> GetAll();
    public Task<ItemDTO?> GetById(int id);
    public Task DeleteById(int id);
    public Task Create(ItemDTO item);
    public Task Update(ItemDTO new_item);
}