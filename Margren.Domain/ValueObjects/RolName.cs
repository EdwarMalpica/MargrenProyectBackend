using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record RolName
    {
        public string value { get; init; }
        
        internal RolName(string value)
        {
            validate(value);
            this.value = value;
        }
        private static void validate(string value)
        {
            if(value == null)
            {
                throw new ArgumentNullException("El Rol no puede ser nulo");
            }
            if(value.Length == 0)
            {
                throw new Exception("No puede ser vacio el rol");
            }
            if(value !="Cliente" || value !="Admin"||value != "Vendedor")
            {
                throw new Exception("No es un rol permitodo, los roles permitodos son: Cliente, Admin, Vendendor");
            }
        }
    }
}
