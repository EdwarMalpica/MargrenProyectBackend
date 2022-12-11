using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record RIQuantity
    {
        public int value { get; set; }
        internal RIQuantity(int value)
        {
            this.value = value;
        }
        public static RIQuantity create(int value)
        {
            return new RIQuantity(value);
        }
        internal static void validate(int value)
        {
            if (value > 0)
            {
                throw new ArgumentException("No puede ser menor a cero la cantidad");
            }
        }
        public static implicit operator int(RIQuantity personId)
        {
            return personId.value;
        }
    }
}
