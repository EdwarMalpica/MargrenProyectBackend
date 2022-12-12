using Margren.Domain.Entities;
using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Repositories
{
    public interface IInventoryRepository
    {
        Task<Inventory> GetInventoryById(InventoryId id);
        Task AddInventory(Inventory inventory);
        Task UpdateInventory(Inventory inventory);
    }
}
