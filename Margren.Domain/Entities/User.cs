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


    }
}
