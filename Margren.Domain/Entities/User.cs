using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Entities
{
    public class User
    {
        public int id_user { get; set; }
        public Email email { get; set; }
        public RolName rol_name { get; set; }
        public PersonId id_person { get; set; }
        public Hash password { get; set; } 

        public User()
        {

        }
        public User(int id_user, Email email, RolName rol_name, PersonId id_person, Hash password)
        {
            this.id_user = id_user;
            this.email = email;
            this.rol_name = rol_name;
            this.id_person = id_person;
            this.password = password;

        }
        public User(int id_user)
        {
            this.id_user = id_user;
        }
    }
}
