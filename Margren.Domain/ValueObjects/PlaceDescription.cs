using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record PlaceDescription
    {
        public string value { get; set; }
        internal PlaceDescription(string value)
        {
            this.value = value;
        }
        public static PlaceDescription create(string value)
        {
            validate(value);
            return new PlaceDescription(value);
        }
        internal static void validate(string value)
        {
            if(value == null)
            {
                throw new ArgumentNullException("No puede ser nula la descripcion");
            }
        }
        
    }
}
