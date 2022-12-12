using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Entities
{
    public class RLShop
    {
        public int id_register_l_compras { get; set; }
        public ShopListId id_shopList { get; set; }
        public InventoryId id_inventory { get; set; }
        public RIQuantity quantity { get; set; }
        public ProductoPrice price { get; set; }
        public ProductUnits units { get; set; }
        public ProductId id_product { get; set; }
    }
}
