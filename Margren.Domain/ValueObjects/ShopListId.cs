using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record ShopListId
    {
        public int value { get; set; }
        internal ShopListId(int value)
        {
            this.value = value;
        }
        public static ShopListId create(int value)
        {
            return new ShopListId(value);
        }
        internal static void validate(int value)
        {
            if (value > 0)
            {
                throw new ArgumentException("No puede ser menor a cero el precio");
            }
        }
        public static implicit operator int(ShopListId personId)
        {
            return personId.value;
        }

    }
}
