using Margren.Domain.Entities;
using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUserById(UserId id);
        Task AddUser(User user);
        Task<List<User>> GetAllUsers();
    }
}
