using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record NumDocument
    {
        public string value { get; init; }

        internal NumDocument(string value)
        {
            validate(value);
            this.value = value;
        }

        public static NumDocument create(string value)
        {
            return new NumDocument(value);
        }

        private static void validate(string value)
        {
            if (value.Length >= 50)
            {
                throw new Exception("El valor del Id Persona tiene que ser menor a 50");
            }

            
        }
    }
}
