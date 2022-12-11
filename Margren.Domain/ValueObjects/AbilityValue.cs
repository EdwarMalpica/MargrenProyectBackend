using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record AbilityValue
    {
        public int value { get; set; }
        internal AbilityValue(int value)
        {
            this.value = value;
        }
        public static AbilityValue create(int value)
        {
            return new AbilityValue(value);
        }
        internal static void validate(int value)
        {
            if(value > 0)
            {
                throw new ArgumentException("El valor no puede ser menor a cero");
            }
        }
    }
}
