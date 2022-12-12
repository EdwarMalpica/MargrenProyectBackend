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
    public class RegisterInventoryRepository : IRegisterInventory
    {
        DataBaseContext db;
        public RegisterInventoryRepository(DataBaseContext db)
        {
            this.db = db;
        }

        public async Task AddRegisterInventory(RegisterInventory inventory)
        {
            await db.AddAsync(inventory);
            await db.SaveChangesAsync();
        }

        public Task DeleteRegisterInventoryById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<RegisterInventory>> GetAllRegisterInventory()
        {
            throw new NotImplementedException();
        }

        public async Task<List<RegisterInventory>> GetRegisterInventoryById(InventoryId id)
        {
            return db.REGISTROS_INVENTARIOS.Where(c => c.id_inventory == id.value).ToList();
        }

        public Task UpdateRegisterInventory(RegisterInventory inventory)
        {
            throw new NotImplementedException();
        }
    }
}
