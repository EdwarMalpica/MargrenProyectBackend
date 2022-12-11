using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record ProductType
    {
        public string value { get; set; }
        internal ProductType(string value)
        {
            this.value = value; 
        }
        public static ProductType create(string value)
        {
            validate(value);
            return new ProductType(value);
        }
        internal static void validate(string value)
        {
            if(value == null)
            {
                throw new Exception("El tipo no puede ser vacio");
            }
        }
    }
}
