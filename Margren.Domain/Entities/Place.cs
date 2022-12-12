using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Entities
{
    public class Place
    {
        public int id_lugar { get; set; }
        public NamePlace name { get; set; }
        public PlaceId id_region { get; set; }   
    }
}
