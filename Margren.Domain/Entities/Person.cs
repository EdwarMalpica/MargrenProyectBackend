using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Entities
{
    public class Person
    {
        public Guid Id { get; set; }
        public PersonName Name { get;private set; }
        public Person(Guid id)
        {
            this.Id = id;
        }
        public void setName(PersonName name)
        {
            Name = name;
        }
    }
}
