using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record PersonId
    {
        public Guid value {get; set;}

        internal PersonId(Guid value_)
        {
            value = value_;
        }
        public static PersonId create(Guid value)
        {
            return new PersonId(value);
        }
        public static implicit operator Guid(PersonId personId)
        {
            return personId.value;
        }
    }
}
