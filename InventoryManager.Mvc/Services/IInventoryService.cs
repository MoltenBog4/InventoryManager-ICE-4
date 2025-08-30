using System.Collections.Generic;
using InventoryManager.Mvc.Models;

namespace InventoryManager.Mvc.Services
{
    public interface IInventoryService
    {
        IReadOnlyCollection<Product> GetAll();
        IReadOnlyCollection<Product> Search(string? query);
        bool TryGet(int productId, out Product? product);
        bool Add(Product product);     // false if ID exists
        bool Update(Product product);  // false if ID missing
        bool Delete(int productId);    // false if ID missing
        int Count { get; }
    }
}
