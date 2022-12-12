using Margren.Domain.Entities;
using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Repositories
{
    public interface IRegisterInventory
    {
        Task<List<RegisterInventory>> GetRegisterInventoryById(InventoryId id);
        Task AddRegisterInventory(RegisterInventory inventory);
        Task DeleteRegisterInventoryById(int id);
        Task<List<RegisterInventory>> GetAllRegisterInventory();
        Task UpdateRegisterInventory(RegisterInventory inventory);
    }
}
