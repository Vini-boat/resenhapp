using Resenhapp.Repositories.Models;
namespace Resenhapp.Services.Interfaces;

public interface IDataBaseService<TEntity> where TEntity: Base
{
    public Task<List<TEntity>> GetAll();
    public Task<TEntity?> GetById(int id);
    public Task Delete(TEntity entity);
    public Task Create(TEntity entity);
    public Task Update(TEntity new_entity);
}