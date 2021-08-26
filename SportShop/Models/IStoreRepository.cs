using System.Linq;

namespace SportShop.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
