using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record ProductId
    {
        public int value { get; init; }
        internal ProductId(int value)
        {
            this.value = value;
        }
        public static ProductId create(int value)
        {
            return new ProductId(value);
        }
        internal static void validate(int value)
        {
            if (value > 0)
            {
                throw new ArgumentException("No puede ser menor a cero id");
            }
        }
        public static implicit operator int(ProductId personId)
        {
            return personId.value;
        }
    }
}
