using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Entities
{
    public class Inventory
    {
        public int id_inventory { get; set; }
        public UserId id_user { get; set; } 
        public AbilityValue ability { get; set; }

    }
}
