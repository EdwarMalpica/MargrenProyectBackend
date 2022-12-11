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
        Task<List<Person>> GetAllPerson();
        Task UpdatePerson(Person person);
        Task<int> GetIdPersonByEmail(Email email);
        Task DeletePerson(int id);

    }
}
