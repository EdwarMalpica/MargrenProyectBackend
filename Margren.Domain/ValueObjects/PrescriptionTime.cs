using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.ValueObjects
{
    public record PrescriptionTime
    {
        public TimeSpan value { get; set; }
        internal PrescriptionTime(TimeSpan value)
        {
            validate(value);
            this.value = value;
        }
        public static PrescriptionTime create(TimeSpan value)
        {
            return new PrescriptionTime(value);
        }
        internal static void validate(TimeSpan value)
        {
            if( value.Minutes ==0 && value.Seconds == 0)
            {
                throw new ArgumentException("No puede ser cero el tiempo");
            }
        }
    }
}
