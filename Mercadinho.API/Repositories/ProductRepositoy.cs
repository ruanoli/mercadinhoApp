using Mercadinho.API.Context;
using Mercadinho.API.Interfaces.Repositories;
using Mercadinho.API.Models;

namespace Mercadinho.API.Repositories;

public class ProductRepositoy : BaseRepository<Product>, IProductRepository
{
    public ProductRepositoy(SQLServerContext context) :  base(context)
    {
    }
}