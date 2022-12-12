using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record AddressId
    {
        public int value { get; set; }
        internal AddressId(int value)
        {
            this.value = value;
        }
        public static AddressId create(int value)
        {
            return new AddressId(value);
        }
        internal static void validate(int value)
        {
            if (value > 0)
            {
                throw new ArgumentException("No puede ser menor a cero el precio");
            }
        }
        public static implicit operator int(AddressId personId)
        {
            return personId.value;
        }

    }
}
