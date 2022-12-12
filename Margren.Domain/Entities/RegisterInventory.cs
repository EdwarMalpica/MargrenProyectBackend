using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Entities
{
    public class RegisterInventory
    {
        public int id_register_inventory { get; set; }
        public InventoryId id_inventory { get; set; }
        public ProductId id_product { get; set; }
        public RIQuantity quantity { get; set; }
    }
}
