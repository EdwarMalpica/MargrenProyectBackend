using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record TypeDocument
    {
        public string value { get; init; }

        internal TypeDocument(string value)
        {
            this.value = value;
        }

        public static TypeDocument create(string value)
        {
            validate(value);
            return new TypeDocument(value);
        }

        private static void validate(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("El valor no puede ser nulo");
            }
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("El valor no puede ser nulo");
            }
            if (value.Length > 3)
            {
                throw new ArgumentNullException("El tipo de documento supera la longitud máxima");
            }
        }
    }
}