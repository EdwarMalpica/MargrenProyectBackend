using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Entities
{
    public class Product
    {
        public int id_product { get; set; }
        public ProductoName name_product { get; set; } 
        public ProductType type { get; set; }  
        public ProductoPrice price { get; set; }
        public ProductUnits units { get; set; }
        public ProductoDescription description { get; set; }
    }
}
