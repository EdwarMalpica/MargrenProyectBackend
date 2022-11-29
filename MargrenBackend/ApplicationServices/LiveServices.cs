

using Margren.Domain.Entities;
using Margren.Domain.Repositories;
using Margren.Domain.ValueObjects;
using MargrenBackend.Commands;

namespace MargrenBackend.ApplicationServices
{
    public class LiveServices
    {
        private readonly IPersonRepository repository;
        public LiveServices(IPersonRepository repository)
        {
            this.repository = repository;
                
        }
        public async Task HandleCommand(CreatePersonCommand createPersonCommand)
        {
            var person = new Person(
                PersonId.create(createPersonCommand.personId));
            person.setName(PersonName.Create(createPersonCommand))
        }
    }
}
