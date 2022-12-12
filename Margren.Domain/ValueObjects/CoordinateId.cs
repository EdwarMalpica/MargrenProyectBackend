using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record CoordinateId
    {
        public int value { get; set; }
        internal CoordinateId(int value)
        {
            this.value = value;
        }
        public static CoordinateId create(int value)
        {
            return new CoordinateId(value);
        }
        internal static void validate(int value)
        {
            if (value > 0)
            {
                throw new ArgumentException("No puede ser menor a cero el precio");
            }
        }
        public static implicit operator int(CoordinateId personId)
        {
            return personId.value;
        }

    }
}
