using Margren.Domain.Entities;
using Margren.Domain.Repositories;
using Margren.Domain.ValueObjects;
using Margren.Infrastructure;
using MargrenBackend.Commands;
//using MargrenBackend.Queries;

namespace MargrenBackend.ApplicationServices
{
    public class LiveServices
    {
        private readonly IPersonRepository repository;
        //private readonly PersonQueries personQueries;

        public LiveServices(IPersonRepository repository
            )
        {

            this.repository = repository;
            //this.personQueries = personQueries;
        }
        public async Task<Person> HandleCommand(CreatePersonCommand createPerson)
        {
            
            var person = new Person();
            person.setId(createPerson.personId);
            person.setFirstName(PersonName.Create(createPerson.first_name));
            person.setLastName(PersonName.Create(createPerson.last_name));
            person.setGender(Gender.create(createPerson.gender));
            person.setTypeDocument(TypeDocument.create(createPerson.type_document));
            person.setNumDocument(NumDocument.create(createPerson.num_document));
            await repository.AddPerson(person);
            //return ContentResponse.createResponse(true, "PERSONA CREADA", null);
            return person;
            //var person = new Person(
                //PersonId.create(createPerson.personId));
           // person.setName(PersonName.Create(createPerson.Name));
            //await repository.AddPerson(person);
        }
        public async Task<Person> GetPersonById(int id)
        {
            var response = await repository.GetPersonById(PersonId.create(id));

            return response;
        }

    }
}
