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
    public class UserRepository : IUserRepository
    {
        DataBaseContext db;
        public UserRepository(DataBaseContext db)
        {
            this.db = db;
        }
    
        public async Task AddUser(User user)
        {
           await db.AddAsync(user);
           await db.SaveChangesAsync();
        }

        public Task<List<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetPasswordByEmail(Email email)
        {

            return  db.USERS.Where(o => o.email.value == email.value).FirstOrDefault();
        }

        public async Task<string> getRoleByIdUser(Email email)
        {
            User user = db.USERS.Where(o => o.email.value == email.value).FirstOrDefault();
            return user.rol_name.value;
        }

        public async Task<User> GetUserById(UserId id)
        {
            return await db.USERS.FindAsync(id.value);
        }

       
    }
}
