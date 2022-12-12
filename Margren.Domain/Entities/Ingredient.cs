using Margren.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Entities
{
    [Keyless]
    public class Ingredient
    {
        public int id_ingredient { get; set; }
        public ProductId id_product { get; set; }
        public PrescriptionId id_prescription { get; set; }
        public IngredientsAmount amount { get; set; }
        public ProductUnits units{ get; set; }

    }
}
