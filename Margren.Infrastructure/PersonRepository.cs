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

        public Task DeletePerson(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Person>> GetAllPerson()
        {
            throw new NotImplementedException();
        }

        public Task<int> GetIdPersonByEmail(Email email)
        {
            throw new NotImplementedException();
        }

        public async Task<Person> GetPersonById(PersonId Id)
        {
            return await db.PERSONAS.FindAsync(Id.value);
        }

        public async Task UpdatePerson(Person person)
        {
            db.Update(person);
            db.SaveChanges();
        }
    }
}
