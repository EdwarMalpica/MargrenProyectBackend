using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record NamePlace
    {
        public string value { get; init; }
        internal NamePlace(string value)
        {
            this.value = value;
        }
        public static NamePlace create(string value)
        {
            validate(value);
            return new NamePlace(value);
        }

        private static void validate(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("No puede ser nulo el valor");
            }
            if (value.Length == 0)
            {
                throw new ArgumentNullException("Debe ser mayor a cero");
            }
            if (value.Length > 30)
            {
                throw new Exception("El rango maximo es 30");
            }
        }
    }
}
