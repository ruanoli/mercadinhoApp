namespace Mercadinho.API.Interfaces.Repositories;

public interface IBaseRepository<TEntity> where TEntity : class
{
    IEnumerable<TEntity> GetAll();
    TEntity? GetById(long id);
    TEntity? Create(TEntity entity);
    TEntity? Update(string id, TEntity? entity);
    void Delete(long id);
}