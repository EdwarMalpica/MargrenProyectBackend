using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record PersonId
    {
        public int value {get; set;}

        internal PersonId(int value_)
        {
            value = value_;
        }
        public static PersonId create(int value)
        {
            
            return new PersonId(value);
        }
        public static implicit operator int(PersonId personId)
        {
            return personId.value;
        }

    }
}
