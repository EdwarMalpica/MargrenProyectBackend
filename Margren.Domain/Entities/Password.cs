using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Entities
{
    public class Password
    {
        public byte[] hash { get; init; }
        public Hash password { get; private set; }


        public Password()
        {

        }
        public Password(string data)
        {
            this.password = Hash.create(data);
        }

        public Password(byte[] user_hash)
        {

            this.password = Hash.create(user_hash);
        }

        public void setPassword(Hash password)
        {
            this.password = password;
        }
    }
}
