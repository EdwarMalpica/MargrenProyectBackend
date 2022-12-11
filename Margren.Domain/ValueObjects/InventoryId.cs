using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record InventoryId
    {
        public int value { get; set; }
        internal InventoryId(int value)
        {
            this.value = value;
        }
        public static InventoryId create(int value)
        {
            return new InventoryId(value);
        }
        internal static void validate(int value)
        {
            if (value > 0)
            {
                throw new ArgumentException("No puede ser menor a cero el id");
            }
        }
        public static implicit operator int(InventoryId inventoryId)
        {
            return inventoryId.value;
        }

    }
}
