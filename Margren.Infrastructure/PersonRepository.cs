using Margren.Domain.Entities;
using Margren.Domain.Repositories;
using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;


namespace Margren.Infrastructure
{
    public class PersonRepository : IPersonRepository
    {
        DataBaseContext db;
        public PersonRepository(DataBaseContext db_)
        {
            db = db_;
        }
        public async Task AddPerson(Person person)
        {
            
            await db.AddAsync(person);
            await db.SaveChangesAsync();
        }

        public Task<List<Person>> GetAllPerson()
        {
            throw new NotImplementedException();
        }

        public async Task<Person> GetPersonById(PersonId Id)
        {
            return await db.PERSONAS.FindAsync(Id.value);
        }
    }
}
