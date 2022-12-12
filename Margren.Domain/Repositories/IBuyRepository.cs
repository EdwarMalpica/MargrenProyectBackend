using Margren.Domain.Entities;
using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Repositories
{
    public interface IBuyRepository
    {
        Task<Buy> GetBuyById(BuyId id);
        Task AddBuy(Buy buy);
        Task DeleteBuyById(int id);
        Task<List<Buy>> GetBuyListById(int id);
        Task UpdateBuy(Buy buy);
    }
}
