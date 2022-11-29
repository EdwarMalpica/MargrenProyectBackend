using Margren.Domain.Entities;
using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Repositories
{
    public interface IPersonRepository
    {
        Task<Person> GetPersonById(PersonId id);
        Task AddPerson(Person person);
    }
}
