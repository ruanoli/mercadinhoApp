using Mercadinho.API.Context;
using Mercadinho.API.Interfaces.Repositories;
using Mercadinho.API.Models;

namespace Mercadinho.API.Repositories;

public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{

    public CategoryRepository(SQLServerContext context) :  base(context)
    {
    }
}