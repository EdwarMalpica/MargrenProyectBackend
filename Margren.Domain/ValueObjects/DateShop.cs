using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record DateShop
    {
        public DateTime value { get; init; }
        internal DateShop(DateTime value)
        {
            this.value = value;
        }
        public static DateShop create(DateTime value)
        {
            return new DateShop(value);
        }
        internal static void validate(DateTime value)
        {
            if(value.Year > 2022)
            {
                throw new ArgumentException("No esta permitido alterar fechas");
            }
        }
    }
}
