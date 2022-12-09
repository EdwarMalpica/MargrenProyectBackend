using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record Gender
    {
        public string value { get; init; }

        internal Gender(string value)
        {
            this.value = value;
        }

        public static Gender create(string value)
        {
            validate(value);
            return new Gender(value);
        }

        private static void validate(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("El genero no puede ser nulo");
            }
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("El genero no puede ser nulo");
            }
            if (value.Length > 1)
            {
                throw new ArgumentNullException("El genero supera la longitud máxima");
            }
            if (!value.ToUpper().Equals("M") && !value.ToUpper().Equals("H"))
            {
                throw new ArgumentNullException("El genero debe ser 'M' ó 'H'");
            }
            //agregar que el valor no puede ser mayor  a 50 caracteres
        }
    }
}
