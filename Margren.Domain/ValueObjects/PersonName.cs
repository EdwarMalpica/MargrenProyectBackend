using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record PersonName
    {
        public String Value { get; init; }
        internal PersonName(string value)
        {
            this.Value = value;
        }
        public static PersonName Create(string value)
        {
            validate(value);
            return new PersonName(value);
        }
        private static void validate(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("El valor no puede ser nulo");
            }
            if(value.Length > 50)
            {
                throw new Exception("El nombre supera el maximo de caracteres permitidos");
            }
        }
    }
}
