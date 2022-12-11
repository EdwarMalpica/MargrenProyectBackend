using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record ProductoPrice
    {
        public int value { get; set; } 
        internal ProductoPrice(int value)
        {
            this.value = value;
        }
        public static ProductoPrice create(int value)
        {
            return new ProductoPrice(value);
        }
        internal static void validate(int value)
        {
            if (value > 0)
            {
                throw new ArgumentException("No puede ser menor a cero el precio");
            }
        }
    }
}
