using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Entities
{
    public class ShopList
    {
        public int id_shopList { get; set; }
        public UserId id_user { get; set; }
        public DateShop date { get; set; }
        public SubTotalShopList subTotal { get; set; }

    }
}
