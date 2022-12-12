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
    public class BuyRepository : IBuyRepository
    {
        DataBaseContext db;
        public BuyRepository(DataBaseContext db)
        {
            this.db = db;
        }

        public async Task AddBuy(Buy buy)
        {
            await db.AddAsync(buy);
            await db.SaveChangesAsync();
        }

        public Task DeleteBuyById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Buy> GetBuyById(BuyId id)
        {
            return await db.COMPRAS.FindAsync(id.value);
        }

        public Task<List<Buy>> GetBuyListById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBuy(Buy buy)
        {
            throw new NotImplementedException();
        }
    }
}
