using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record ProductoName
    {
        public string value { get; set; }
        internal ProductoName(string value)
        {
            this.value = value;
        }
        public static ProductoName create(string value)
        {
            return new ProductoName(value);
        }
        internal static void validate(string value)
        {
            if (value.Length < 0)
            {
                throw new Exception("EL nombre no puede ser vacio");
            }
        }
    }
}
