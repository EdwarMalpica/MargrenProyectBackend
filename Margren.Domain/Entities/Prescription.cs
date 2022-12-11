using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Entities
{
    public  class Prescription
    {
        public int id_prescription { get; set; }
        public PrescriptionType type_prescription { get; set; }
        public PrescriptionName name { get; set; } 
        public PrescriptionDifficulty difficulty { get; set; }
        public PrescriptionTime time { get; set; }
    }
}
