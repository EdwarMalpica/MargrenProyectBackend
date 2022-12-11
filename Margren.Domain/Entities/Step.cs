using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Margren.Domain.ValueObjects;

namespace Margren.Domain.Entities
{
    public class Step
    {
        public int id_step { get; set; }
        public PrescriptionId id_prescription { get; set; }
        public ProductoDescription description { get; set; }
    }
}
