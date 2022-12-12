using Margren.Domain.Entities;
using Margren.Domain.Repositories;
using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Infrastructure
{
    public class AddressRepository : IAddressRepository

    {
        DataBaseContext db;
        public AddressRepository(DataBaseContext db)
        {
            this.db = db;
        }
    
        public async Task AddAddress(Address address)
        {
            await db.AddAsync(address);
            await db.SaveChangesAsync();
        }

        public async Task<Address> GetAddressById(AddressId id)
        {
            return await db.DIRECCIONES.FindAsync(id.value);
        }

        public Task<Address> GetAddressByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAddress(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
