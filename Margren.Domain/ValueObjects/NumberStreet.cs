using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record NumberStreet
    {
        public int value { get; set; }
        internal NumberStreet(int value)
        {
            this.value = value;
        }
        public static NumberStreet create(int value)
        {
            return new NumberStreet(value);
        }
        internal static void validate(int value)
        {
            if (value < 0)
            {
                throw new Exception("Debe ser mayor a cero el valor");
            }
        }
        public static implicit operator int(NumberStreet numberStreet)
        {
            return numberStreet.value;
        }
    }
}
