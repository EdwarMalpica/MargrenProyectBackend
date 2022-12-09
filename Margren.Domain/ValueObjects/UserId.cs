using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    

    public record UserId
    {
        public int value { get; init; }
        
        internal UserId(int value)
        {
            this.value = value;
        }
        public static UserId create(int value) {
            validate(value);
            return new UserId(value);
        }
        private static void validate(int value)
        {
            if(value < 0)
            {
                throw new ArgumentOutOfRangeException("El valor debe ser mayor a cero");
            }
        }
        public static implicit operator int(UserId userId)
        {
            return userId.value;
        }
    }
}
