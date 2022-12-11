using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record KinfOfStreet
    {
        public string value { get; set; }
        internal KinfOfStreet(string value)
        {
            this.value  = value;

        }
        public static KinfOfStreet create(string value)
        {
            return new KinfOfStreet(value);
        }
        internal static void validate(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("El valor no puede ser nulo");
            }
            if (!value.Equals("Calle") || !value.Equals("Carrera"))
            {
                throw new Exception("No esta permitido este tipo de calle");
            }     
        }
    }
}
