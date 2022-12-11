using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record IngredientsAmount
    {
        public int value { get; set; }
        internal IngredientsAmount(int value)
        {
            this.value = value;
        }
        public static IngredientsAmount create(int value)
        {
            return new IngredientsAmount(value);
        }
        internal static void validate(int value)
        {
            if (value > 0)
            {
                throw new ArgumentException("No puede ser menor a cero el precio");
            }
        }
        public static implicit operator int(IngredientsAmount personId)
        {
            return personId.value;
        }
    }
}
