using Resenhapp.Repositories.Models;
using Resenhapp.Repositories.DTOs;
namespace Resenhapp.Services.Interfaces;

public interface IItemService
{
    public Task<List<Item>> GetAll();
    public Task<Item?> GetById(int id);
    public Task Delete(Item item);
    public Task Create(Item item);
    public Task Update(ItemDTO new_item);
}