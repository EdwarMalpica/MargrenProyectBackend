using Margren.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Repositories
{
    public interface IAddressRepository
    {
        Task<Address> GetAddressById(int id);
        Task<Address> GetAddressByName(string name);
        Task AddAddress(Address address);
        Task UpdateAddress(Address address);
    }
}
