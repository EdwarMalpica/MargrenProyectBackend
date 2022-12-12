using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record BuyId
    {
        public int value { get; set; }
        internal BuyId(int value)
        {
            this.value = value;
        }
        public static BuyId create(int value)
        {
            return new BuyId(value);
        }
        internal static void validate(int value)
        {
            if (value > 0)
            {
                throw new ArgumentException("No puede ser menor a cero el precio");
            }
        }
        public static implicit operator int(BuyId personId)
        {
            return personId.value;
        }

    }
}
