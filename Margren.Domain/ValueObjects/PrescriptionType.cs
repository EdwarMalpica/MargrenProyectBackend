using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record PrescriptionType
    {
        public string value { get; set; }
        internal PrescriptionType(string value)
        {
            this.value = value;
        }
        public static PrescriptionType create(string value)
        {
            return new PrescriptionType(value);
        }
        internal static void validate(string value)
        {
            if (value.Length < 0)
            {
                throw new Exception("EL tipo no puede ser vacio");
            }
        }

    }
}
