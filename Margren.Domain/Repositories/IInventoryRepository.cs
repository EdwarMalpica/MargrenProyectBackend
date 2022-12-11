using Margren.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Repositories
{
    public interface IInventoryRepository
    {
        Task<Inventory> GetInventoryById(int id);
        Task AddInventory(Inventory inventory);
        Task UpdateInventory(Inventory inventory);
    }
}
