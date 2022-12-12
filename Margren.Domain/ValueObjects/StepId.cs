using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record StepId
    {
        public int value { get; set; }
        internal StepId(int value)
        {
            this.value = value;
        }
        public static StepId create(int value)
        {
            return new StepId(value);
        }
        internal static void validate(int value)
        {
            if (value > 0)
            {
                throw new ArgumentException("No puede ser menor a cero el precio");
            }
        }
        public static implicit operator int(StepId personId)
        {
            return personId.value;
        }

    }
}
