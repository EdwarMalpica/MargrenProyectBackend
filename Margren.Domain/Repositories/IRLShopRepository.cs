using Margren.Domain.Entities;
using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Repositories
{
    public interface IRLShopRepository
    {
        Task<List<RLShop>> GetRLShopByID(ShopListId id);
        Task AddRlShop(RLShop rShop);
        Task DeleteRlShopById(int id);
        Task UpdateRlShop(RLShop rShop);
    }
}
