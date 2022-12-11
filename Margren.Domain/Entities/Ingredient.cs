using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Entities
{
    public class Ingredient
    {
        public ProductId id_product { get; set; }
        public PrescriptionId id_prescription { get; set; }
        public IngredientsAmount amount { get; set; }
        public ProductUnits units{ get; set; }

    }
}
