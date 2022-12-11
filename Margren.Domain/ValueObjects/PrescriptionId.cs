using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record PrescriptionId
    {
        public int value { get; set; }
        internal PrescriptionId(int value)
        {
            this.value = value;
        }
        public static PrescriptionId create(int value)
        {
            return new PrescriptionId(value);
        }
        internal static void validate(int value)
        {
            if (value > 0)
            {
                throw new ArgumentException("No puede ser menor a cero el precio");
            }
        }
        public static implicit operator int(PrescriptionId personId)
        {
            return personId.value;
        }
    }
}
