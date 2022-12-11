using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Entities
{
    public class Coordinate
    {
        public int id_address { get; set; } 
        public CoordinateValue latitude { get; set; }  
        public CoordinateValue lenght { get; set; } 

    }
}
