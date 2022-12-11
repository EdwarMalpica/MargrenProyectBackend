using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record PlaceId
    {
        public int value  { get; set; }
        internal PlaceId(int value)
        {
            this.value = value;
        }
        public static PlaceId create(int value)
        {
            validate(value);
            return new PlaceId(value);
        }
        internal static void validate(int value)
        {
            if(value < 0)
            {
                throw new ArgumentOutOfRangeException("El id debe ser mayor a cero");
            }
        }
        public static implicit operator int(PlaceId placeId)
        {
            return placeId.value;
        }

    }
}
