using Margren.Domain.Entities;
using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Repositories
{
    public interface IAddressRepository
    {
        Task<Address> GetAddressById(AddressId id);
        Task<Address> GetAddressByName(string name);
        Task AddAddress(Address address);
        Task UpdateAddress(Address address);
    }
}
