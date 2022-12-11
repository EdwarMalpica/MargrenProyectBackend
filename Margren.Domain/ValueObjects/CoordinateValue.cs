using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record CoordinateValue
    {
        public string value { get; set; }
        internal CoordinateValue(string value)
        {
            this.value = value;
        }
        public static CoordinateValue create(string value)
        {
            return new CoordinateValue(value);
        }
        internal static void validate(string value)
        {
            if (value == null)
            {
                throw new Exception("El valor no puede ser nulo");
            }
            if(value.Length > 30)
            {
                throw new Exception("El valor no puede ser mayor a 30 caracteres");
            }
        }
}
