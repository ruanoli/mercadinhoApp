using Mercadinho.API.Context;
using Mercadinho.API.Interfaces.Repositories;

namespace Mercadinho.API.Repositories;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    private readonly SQLServerContext _context;

    public BaseRepository(SQLServerContext context) :  base()
    {
        _context = context;
    }

    public IEnumerable<TEntity> GetAll()
    {
        return _context.Set<TEntity>().ToList();
    }
    

    public TEntity? GetById(long id)
    {
        return  _context.Set<TEntity>().Find(id);
    }

    public TEntity? Create(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
        _context.SaveChanges();
        return entity;
    }

    public TEntity? Update(string id, TEntity? entity)
    {
        _context.Set<TEntity>().Update(entity);
        _context.SaveChanges();
        return entity;
    }

    public void Delete(long id)
    {
        _context.Set<TEntity>().Remove(GetById(id));
        _context.SaveChanges();
    }
}