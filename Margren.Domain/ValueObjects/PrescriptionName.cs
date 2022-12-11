using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record PrescriptionName
    {
        public string value { get; set; }
        internal PrescriptionName(string value)
        {
            this.value = value;
        }
        public static PrescriptionName create(string value)
        {
            return new PrescriptionName(value);
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
