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
    public class RLShopRepository : IRLShopRepository
    {
        DataBaseContext db;
        public RLShopRepository(DataBaseContext db)
        {
            this.db = db;
        }

        public async Task AddRlShop(RLShop rShop)
        {
            await db.AddAsync(rShop);
            await db.SaveChangesAsync();
        }


        public Task DeleteRlShopById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<RLShop>> GetRLShopByID(ShopListId id)
        {
            return db.REGISTROS_L_COMPRAS.Where(c => c.id_shopList == id.value).ToList();
        }

        public Task UpdateRlShop(RLShop rShop)
        {
            throw new NotImplementedException();
        }
    }
}
