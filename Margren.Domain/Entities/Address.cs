using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Entities
{
    public class Address
    {
        public int id_address { get; set; }
        public KinfOfStreet kind_of_street { get; set; }
        public NumberStreet number_street { get; set; }
        public NumberStreet num_one { get; set; }   
        public NumberStreet num_two { get; set; }   
        public PlaceDescription description {get; set;}
        public PersonId id_person { get; set; } 
        public PlaceId id_lugar { get; set; }   

    }
}
