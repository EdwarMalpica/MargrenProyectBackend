using Margren.Domain.Entities;
using Margren.Domain.Repositories;
using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Infrastructure
{
    public class InventoryRepository : IInventoryRepository
    {
        DataBaseContext db;
        public InventoryRepository(DataBaseContext db)
        {
            this.db = db;
        }

        public async Task AddInventory(Inventory inventory)
        {
            await db.AddAsync(inventory);
            await db.SaveChangesAsync();
        }

        public async Task<Inventory> GetInventoryById(InventoryId id)
        {
            return await db.INVENTARIOS.FindAsync(id.value);
        }

        public Task UpdateInventory(Inventory inventory)
        {
            throw new NotImplementedException();
        }
    }
}
