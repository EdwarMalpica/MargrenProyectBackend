using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record Hash
    {
        public byte[] value { get; init; }

        internal Hash(byte[] value)
        {
            this.value = value;
        }

        public static Hash create(string value)
        {
            validate(value);
            return new Hash(encrypt(value));
        }

        private static byte[] encrypt(string value)
        {
            byte[] hash = SHA512.Create().ComputeHash(Encoding.UTF8.GetBytes(value));
            return hash;
        }


        private static void validate(string value)
        {
            if (value == null)
            {
                throw new Exception("La contraseña no puede ser nula");
            }
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("La contraseña no puede ser nula");
            }
            if (value.Length > 120)
            {
                throw new Exception("La contraseña supera la longitud máxima");
            }

        }
    } 
}
