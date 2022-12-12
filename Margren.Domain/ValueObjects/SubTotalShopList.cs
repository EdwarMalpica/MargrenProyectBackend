using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record SubTotalShopList
    {
        public int value { get; set; }
        internal SubTotalShopList(int value)
        {
            this.value = value;
        }
        public static SubTotalShopList create(int value)
        {
            return new SubTotalShopList(value);
        }
        internal static void validate(int value)
        {
            if (value > 0)
            {
                throw new ArgumentException("No puede ser menor a cero el precio");
            }
        }
        public static implicit operator int(SubTotalShopList personId)
        {
            return personId.value;
        }

    }
}
