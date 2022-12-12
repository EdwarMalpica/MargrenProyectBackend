using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Entities
{
    public class Buy
    {
        public int id_shop { get; set; }
        public ShopListId id_shopList { get; set; }
        public UserId id_user { get; set; }

    }
}
