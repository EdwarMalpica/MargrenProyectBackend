using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record PersonFirstName
    {
        public string FirstName { get; set; }
        internal PersonFirstName(string value)
        {
            FirstName = value;
        }
        public static PersonFirstName Create(string value)
        {
            validate(value);
            return new PersonFirstName(value);
        }
        private static void validate(string value)
        {
            if(value == null)
            {
                throw new ArgumentNullException("El valor no puede ser nulo");
            }
            if(value.Length >= 50)
            {
                throw new ArgumentOutOfRangeException("El valor es demasiado grande");
            }
        }
    }
}
